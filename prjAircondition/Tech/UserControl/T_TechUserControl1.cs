using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace prjAircondition.Tech
{
    public partial class T_TechUserControl1 : UserControl
    {
        private string licenseImageFolderPath;
        private string imageFolderPath; // 圖片存放位置
        private string selectedLicensePhotoFullPath = null;

        public T_TechUserControl1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;

            InitImageFolder();
            InitBindingSource(); // << 重點：把 BindingSource 初始設定集中處理
            InitImageLicenseFolder();
        }

        // 初始化 License 存放目錄
        private void InitImageLicenseFolder()
        {
            string projectRootPath = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
            //放到TechResources\LicenseResources
            licenseImageFolderPath = Path.Combine(projectRootPath, "TechResources", "LicenseResources");
            Directory.CreateDirectory(licenseImageFolderPath);
        }

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t_ACDataSet1);
        }

        private void T_TechUserControl1_Load(object sender, EventArgs e)
        {
            //先把該帳號資訊傳入 帳號文字輸入框裡面
            //techAccountTextBox.Text = TechloginAccount;
            // 所有師傅資料導入
            this.techniciansTableAdapter.Fill(this.t_ACDataSet1.Technicians);
            MessageBox.Show($"目前Technicians共有 {this.t_ACDataSet1.Technicians.Rows.Count} 筆資料");
            //綁gridView和中界點資料
            // BindingSource 是綁 DataTable資料表，
            //但 DataGridView 設計器在第一次設計階段並沒有
            //正確幫你自動產生欄位(AutoGenerateColumns 問題)。

            // 先載入證照資料
            this.licensesTableAdapter1.Fill(this.t_ACDataSet1.licenses);

            //綁了 DataTable 不是整個 DataSet，
            //設計器無法幫你預先產生正確欄位。
            //要格外加方法
            //this.techniciansDataGridView.AutoGenerateColumns = true;
            this.techniciansDataGridView.DataSource = this.techniciansBindingSource;
            FilterLicenseByTechnician();
            BindControl();
            //綁定證照控制項
            BindLicenseControl();
            SetTechDateTimePickers();//師傅個人資訊時間初始化
            SetLicenseDateTimePickers();   // <-- 這就是你新加進來的證照時間初始化
            LoadImageFromDS();
        }

        //依照 師傅id 篩選證照
        private void FilterLicenseByTechnician()
        {
            licensebindingSource1.Filter = $"T_id = {GetCurrentTechnicianId()}";
        }

        //取得當前師傅ID
        private object GetCurrentTechnicianId()
        {
            if (this.techniciansBindingSource.Current is DataRowView drv)
            {
                return Convert.ToInt32(drv["T_id"]);
            }
            else
            {
                return -1;
            }
        }

        // 綁定 License UI 控制項
        private void BindLicenseControl()
        {
            licenseNameTextBox.DataBindings.Add("Text", licensebindingSource1, "license_name");
            licenseDesTextBox.DataBindings.Add("Text", licensebindingSource1, "image_description");
            issuedByTextBox.DataBindings.Add("Text", licensebindingSource1, "issued_by");

            //新增時可以讓人選擇日期，所以你綁 DateTime.Now 沒有問題。
            //最後一個參數是當資料行值為 DBNull 或 null 時，顯示在控制項上的預設值 預設給使用者看得
            //參數內容
            //propertyName, dataSource, dataMember, formattingEnabled, updateMode, **nullValue * *
            //TODO
            DateTime defaultDate = DateTime.Now;
            createdAtPickerTech.DataBindings.Clear();
            updatedAtPickerTech.DataBindings.Clear();
            issueDateTimePicker1.DataBindings.Add("Value", licensebindingSource1, "issue_date", true, DataSourceUpdateMode.Never, DateTime.Now);
            expirydateTimePicker1.DataBindings.Add("Value", licensebindingSource1, "expiry_date", true, DataSourceUpdateMode.Never, DateTime.Now);
            createdAtPickerTech.DataBindings.Add("Value", licensebindingSource1, "created_at", true, DataSourceUpdateMode.Never, defaultDate);
            updatedAtPickerTech.DataBindings.Add("Value", licensebindingSource1, "updated_at", true, DataSourceUpdateMode.Never, defaultDate);
        }

        //中界點綁定設定
        private void InitBindingSource()
        {
            // techniciansBindingSource  BindingSource 綁定師傅資料表(DataTable)
            this.techniciansBindingSource.DataSource = this.t_ACDataSet1.Technicians;

            // 讓 LicenseBindingSource 綁定 Licenses 資料表
            this.licensebindingSource1.DataSource = this.t_ACDataSet1.licenses;
            // licenseBindingSource 做出 Master-Detail 綁定
            //Filter 其實是 DataView.RowFilter 的封裝。
            //BindingSource 層 Filter 屬性找到那筆欄位值 等於多少的資料列
            //Filter 不是 SQL 語法，而是 .NET DataView 語法
            //這裡比對T_id 篩選資料列

            // techniciansDataGridView 已經在設計器上 DataSource 綁定了 techniciansBindingSource
        }

        //個人 師傅資訊業面
        public void BindControl()
        {
            // 先清除舊的 DataBinding，避免重複綁定
            userNameTextBox.DataBindings.Clear();
            phone_textBox.DataBindings.Clear();
            NickNameTextBox.DataBindings.Clear();
            techAccountTextBox.DataBindings.Clear();
            createdAtPickerTech.DataBindings.Clear();
            updatedAtPickerTech.DataBindings.Clear();

            // 2. 綁定 BindingSource 個人資訊頁面也綁定中介層資訊 都綁在techniciansBindingSource
            // 隨資料列移動

            userNameTextBox.DataBindings.Add("Text", this.techniciansBindingSource, "name");
            phone_textBox.DataBindings.Add("Text", this.techniciansBindingSource, "phone");
            NickNameTextBox.DataBindings.Add("Text", this.techniciansBindingSource, "NickName");
            techAccountTextBox.DataBindings.Add("Text", this.techniciansBindingSource, "account");

            //全部師傅的 個人師傅名稱label 綁定bindingsource Name欄位
            this.labelTechNameInALLTechs.DataBindings.Add("Text", this.techniciansBindingSource, "name");

            // 綁定「建立時間」，只能讀取，使用者不能改
            createdAtPickerTech.DataBindings.Add(
                "Value",
                this.techniciansBindingSource,
                "created_at",
                true,
                DataSourceUpdateMode.Never
            );

            // 綁定「更新時間」，也是讀取用，改動放在 Save 時程式裡
            updatedAtPickerTech.DataBindings.Add(
                "Value",
                this.techniciansBindingSource,
                "updated_at",
                true,
                DataSourceUpdateMode.Never
            );

            //if (acDataSet11.Technicians.Rows.Count > 0)
            //{
            //    DataRow row = acDataSet11.Technicians.Rows[0];
            //    userNameTextBox.Text = row["name"].ToString();
            //    phone_textBox.Text = row["phone"].ToString();
            //    NickNameTextBox.Text = row["Nickname"].ToString();
            //}
        }

        private void InitDateTimePicker(DateTimePicker picker, bool enabled = false, bool hideInitially = false)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            picker.Enabled = enabled;
            picker.Visible = !hideInitially;
        }

        private void SetTechDateTimePickers()
        {
            //// 針對「建立時間」DateTimePicker 做設定
            //createdAtPickerTech.Format = DateTimePickerFormat.Custom;
            //createdAtPickerTech.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            //createdAtPickerTech.Enabled = false; // 讓使用者不能手動改

            //// 針對「更新時間」DateTimePicker 做設定 幾時幾分幾秒
            //updatedAtPickerTech.Format = DateTimePickerFormat.Custom;
            //updatedAtPickerTech.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            //updatedAtPickerTech.Enabled = false; // 讓使用者不能手動改
            InitDateTimePicker(createdAtPickerTech);
            InitDateTimePicker(updatedAtPickerTech);
        }

        //證照類載入時不顯示，直到送回DB
        private void SetLicenseDateTimePickers()
        {
            // 建立時間
            //createdAtPickerLicense.Format = DateTimePickerFormat.Custom;
            //createdAtPickerLicense.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            //createdAtPickerLicense.Enabled = false;
            //createdAtPickerLicense.Visible = false; // 新增階段先隱藏

            // 更新時間
            //updatedAtPickerLicense.Format = DateTimePickerFormat.Custom;
            //updatedAtPickerLicense.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            //updatedAtPickerLicense.Enabled = false;
            //updatedAtPickerLicense.Visible = false;
            InitDateTimePicker(createdAtPickerLicense, false, true);
            InitDateTimePicker(updatedAtPickerLicense, false, true);
        }

        //資料庫照片位置存放處
        private void InitImageFolder()
        {
            //找個資料夾放圖片並給個資料夾名稱
            string projectRootPath = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
            imageFolderPath = Path.Combine(projectRootPath, "TechResources");
            Directory.CreateDirectory(imageFolderPath);
        }

        //離線資料庫載入 讀取離線資料庫照片
        private void LoadImageFromDS()
        {
            //確認BindingSource所指的位置指向哪筆資料 .Current 且是否是 DataRowView 型別物件
            //BindingSource 在綁 DataTable 時，每一筆其實是用 DataRowView 包裝起來的
            //並存入DataRowView drv變數
            if (techniciansBindingSource.Current is DataRowView drv)
            {
                //從 DataRowView 裡面，取出實際的資料列 DataRow 用.Row屬性
                //用DataRow讀取那筆資料列的東西 row[""]
                DataRow row = drv.Row;
                //確保row["photo"]欄位不是nuLL 取 裡面內容轉換成字串後不是空白
                if (!row.IsNull("photo") && !string.IsNullOrWhiteSpace(row["photo"].ToString()))
                {
                    //取出照片檔名
                    string filename = row["photo"].ToString();
                    //組合出完整路徑位置(路徑+檔名)
                    string fullPath = Path.Combine(imageFolderPath, filename);
                    //檔案存在顯示 否則就是Null
                    pictureBox1.Image = File.Exists(fullPath) ? Image.FromFile(fullPath) : null;
                }
                else
                {
                    //欄位沒有值也是預設圖片
                    LoadDefaultImage();
                }
            }
            //Binding source此時沒有指向任何筆資料時也是顯示預設圖片
            else
            {
                LoadDefaultImage();
            }
        }

        //預設圖片位置
        private void LoadDefaultImage()
        {
            //給預設照片 都在 C:\Users\yozora\Desktop\AC_Middern\NewTech\Aircondition\TechResources底下
            string defaultPath = Path.Combine(imageFolderPath, "default.png");
            //執行檔案預設路徑
            //MessageBox.Show("Application.StartupPath: " + Application.StartupPath);

            MessageBox.Show("載入預設圖");

            if (File.Exists(defaultPath))
            {
                pictureBox1.Image = Image.FromFile(defaultPath);
            }
            else
            {
                pictureBox1.Image = null; // 沒預設圖就空白
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            //另一種寫法
            //DataRow row = this.acDataSet11.Technicians.Rows[0];
            //row["name"] = this.userNameTextBox.Text;
            //row["phone"] = this.phone_textBox.Text;
            //row["NickName"] = this.NickNameTextBox.Text;

            //techniciansTableAdapter1.Update(this.acDataSet11.Technicians);

            //把更新時間欄位給現在時間
            // 先確認目前 techniciansBindingSource 指向哪一筆資料
            if (this.techniciansBindingSource.Current is DataRowView dataRowView)
            {
                //先把dataRowView轉換成datarow 那筆資料列再去拿欄位內容的值
                DataRow dataRow = dataRowView.Row;

                //更新update_at欄位
                //用靜態類別的屬性 目前時間
                DateTime now = DateTime.Now;
                dataRow["updated_at"] = now;

                //更新UI顯示時間 同步顯示
                updatedAtPickerTech.Value = now;

                //照片有更動時，更新photo欄位內容
                if (this.pictureBox1.Tag != null)
                {
                    //把那筆資料列欄位換成這個Tag名稱
                    string fileName = this.pictureBox1.Tag.ToString();
                    dataRow["photo"] = fileName;

                    //儲存時複製一份檔案到資料夾裡 路徑
                    string storePath = Path.Combine(imageFolderPath, fileName);

                    //// 檢查來源路徑是否有效，才進行檔案複製
                    //if (!string.IsNullOrEmpty(selectedPhotoFullPath) && File.Exists(selectedPhotoFullPath))
                    //{
                    //    // 避免重複覆蓋同名檔案 複製一份檔案到這路徑storePath下
                    //    // true 代表有同名檔案時覆蓋
                    //    File.Copy(selectedPhotoFullPath, storePath, true);
                    //    selectedPhotoFullPath = null;
                    //}
                }
            }
            //強制觸發整個表單(Form 或 UserControl) 上所有控制項的驗證事件。 如果UI
            //比如TextBox 的格式檢查，確認控制項內容是正確的
            this.Validate();

            // 將目前 UI 控制項的值，寫入 BindingSource 內部資料列 (DataRow)
            // 把控制項的值 丟回techniciansBindingSource
            this.techniciansBindingSource.EndEdit();

            //因為bindingsource綁定 this.t_ACDataSet1.Technicians
            //所以此時這資料表已經有變動了，我們用techniciansTableAdapter1
            //將離線 DataTable(t_ACDataSet1.Technicians) 的變更推送回資料庫
            //Update() 將 離線資料表 Technicians 推送回實體DB
            this.techniciansTableAdapter.Update(this.t_ACDataSet1.Technicians);
            MessageBox.Show("資料已更新");
        }

        //上傳 證照圖片按鈕
        private void License_Upload_button_Click(object sender, EventArgs e)
        {
            //在對話框內的文字：「Image Files (.jpg;.jpeg;*.png)」
            // | 後面接的是實際的副檔名格式
            openFileDialog1.Filter = "Images Files(.jpg jpeg png) |*.jpg;*.jpeg;*.png";
            //視窗最上面會顯示「選擇圖片檔案」
            openFileDialog1.Title = "選擇圖片檔案";
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                //照片原始路徑位置
                string sourcePath = this.openFileDialog1.FileName;
                //檔名
                string fileName = Path.GetFileName(sourcePath);
                //目的地路徑
                string destPath = Path.Combine(imageFolderPath, fileName);

                // 複製圖片到資料夾 (避免直接讀使用者原始位置)
                File.Copy(sourcePath, destPath, true);
                selectedLicensePhotoFullPath = sourcePath;
                // 顯示圖片存到p1 BOX
                this.licensepictureBox.Image = Image.FromFile(destPath);

                // 把這個TAG給值 為目前所選檔案名稱
                this.licensepictureBox.Tag = fileName;
                MessageBox.Show($"已上傳 {fileName}");
            }
            else
            {
                MessageBox.Show("取消");
            }
        }

        //假如有照片上傳的路就 先初始化   upDate回去時再複製一份推送回DB
        private string selectedPhotoFullPath = null;

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            //在對話框內的文字：「Image Files (.jpg;.jpeg;*.png)」
            // | 後面接的是實際的副檔名格式
            openFileDialog1.Filter = "Images Files(.jpg jpeg png) |*.jpg;*.jpeg;*.png";
            //視窗最上面會顯示「選擇圖片檔案」
            openFileDialog1.Title = "選擇圖片檔案";
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                //照片原始路徑位置
                string sourcePath = this.openFileDialog1.FileName;
                //拿檔名
                string fileName = Path.GetFileName(sourcePath);

                //先暫存檔案路徑，還沒上傳，暫放一下
                selectedPhotoFullPath = sourcePath;

                // 顯示圖片存到pictureBox1
                this.pictureBox1.Image = Image.FromFile(sourcePath);

                // 把這個TAG給值 為目前所選檔案名稱 方便後續判斷這個圖片有沒有TAG值
                this.pictureBox1.Tag = fileName;
                MessageBox.Show($"已上傳 {fileName}");
            }
            else
            {
                MessageBox.Show("取消");
            }
        }

        //顯示師傅資訊
        private void showTechButton1_Click(object sender, EventArgs e)
        {
            if (this.techniciansBindingSource.Current != null)
            {
                // 載入圖片
                LoadImageFromDS();

                // 切換到師傅個人資訊頁
                this.tabControl1.SelectedTab = this.TechPage;
            }
            else
            {
                MessageBox.Show("請先選擇一筆資料");
            }
        }

        private void techniciansBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //設定好label 顯示 第幾筆/ 共有幾筆
            this.ALLTechLabel1.Text = $"{this.techniciansBindingSource.Position + 1} / {this.techniciansBindingSource.Count}";

            RefreshLicenseBinding();
        }

        //師傅切換時，也切換顯示
        private void RefreshLicenseBinding()
        {
            if (licensebindingSource1 != null)
            {
                licensebindingSource1.Filter = $"T_id = {GetCurrentTechnicianId()}";
            }
        }

        private void AllTechbutton1_Click(object sender, EventArgs e)
        {
            this.techniciansBindingSource.Position = 0;
        }

        private void AllTechbutton2_Click(object sender, EventArgs e)
        {
            this.techniciansBindingSource.Position -= 1;
        }

        private void AllTechbutton3_Click(object sender, EventArgs e)
        {
            this.techniciansBindingSource.Position += 1;
        }

        private void AllTechbutton4_Click(object sender, EventArgs e)
        {
            //到最後一筆索引
            this.techniciansBindingSource.Position = this.techniciansBindingSource.Count - 1;
        }

        //dataGridView 資料列雙擊跳
        private void techniciansDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (techniciansBindingSource.Current is DataRowView drv)
            {
                // 直接從 DataRowView 取出 T_id
                int technicianID = Convert.ToInt32(drv["T_id"]);

                // 這邊你根本不需要重新撈資料
                // 因為 techniciansBindingSource 已經正確指到這筆資料了

                // 直接切換到個人資料頁面
                this.tabControl1.SelectedTab = this.TechPage;

                // 順手載入圖片（因為你圖片是隨 SelectionChanged 或 ShowTechnicianDetail 載入的）
                LoadImageFromDS();
            }
        }

        private void DeleteTechbutton1_Click(object sender, EventArgs e)
        {
            if (this.techniciansBindingSource.Current != null)
            {
                // 1. BindingSource 刪除當前資料列
                this.techniciansBindingSource.RemoveCurrent();

                MessageBox.Show("已刪除");
            }
            else
            {
                MessageBox.Show("目前沒有選取任何資料");
            }
        }

        //回推 師傅資料列 到資料庫
        private void UpdateTechToDBbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 確認 UI 資料有效，先觸發驗證邏輯
                this.Validate();

                // 2. 通知 BindingSource：目前編輯完成，將 UI 上變更寫回 DataSet
                this.techniciansBindingSource.EndEdit();
                // 3. 將離線資料表推送回資料庫
                this.techniciansTableAdapter.Update(this.t_ACDataSet1.Technicians);
                MessageBox.Show("成功儲存");
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗: " + ex.Message);
            }
        }

        private void InsertTechButton1_Click(object sender, EventArgs e)
        {
            //和FormTech共用一份離線資料表
            Form f = new FormTech(this.t_ACDataSet1);
            f.Show();
        }

        private void techniciansDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.techniciansDataGridView.Columns[e.ColumnIndex].Name == "gender" && e.Value != null)
            {
                // 新增防呆判斷
                bool gender = false; // 預設男生
                if (e.Value != DBNull.Value && e.Value != null)
                    gender = Convert.ToBoolean(e.Value);
                e.Value = gender ? "女生" : "男生";
                e.FormattingApplied = true;
            }
        }

        //切換到師父 所有圖片一覽頁面
        private void btnTechAllLicense_Click(object sender, EventArgs e)
        {
            this.tabControl2.SelectedTab = this.LicenseAllPage;
        }

        //新增證照功能
        private void btnAddLicense_Click(object sender, EventArgs e)
        {
            // 先透過 BindingSource 產生新資料列（會自動幫你建好 DataRowView）
            var newRowView = (DataRowView)licensebindingSource1.AddNew();

            // 設定欄位值
            newRowView["T_id"] = GetCurrentTechnicianId();  // 外鍵，指向目前的師傅

            newRowView["created_at"] = DBNull.Value; //兩個初始欄位都給NULL
            newRowView["updated_at"] = DBNull.Value;

            // 結束編輯（通常你可以等 UI 完整編輯後再呼叫 EndEdit）
            licensebindingSource1.EndEdit();

            // 移動游標到新增的這一筆（可有可無，看你要不要跳到最後一筆方便觀察）
            licensebindingSource1.MoveLast();
        }

        //儲存 (包含照片 證照資料一起update回去)
        private void btnSaveLicense_Click(object sender, EventArgs e)
        {
            // 先確認目前 BindingSource 是否有指向資料列
            if (licensebindingSource1.Current is DataRowView drv)
            {
                DataRow row = drv.Row;
                DateTime now = DateTime.Now;

                bool isNew = row.IsNull("created_at");
                //只在第一次編輯創立時間
                if (isNew)
                {
                    row["created_at"] = now;
                }

                //時間控制項管理
                //不論是不是新資料，每次都顯示 created_at 值 (用資料行內的值)
                createdAtPickerLicense.Value = Convert.ToDateTime(row["created_at"]);
                createdAtPickerLicense.Visible = true;

                // 每次都更新 updated_at 並且顯示資料
                row["updated_at"] = now;

                updatedAtPickerLicense.Visible = true;

                // 照片處理
                if (this.licensepictureBox.Tag != null)
                {
                    // 取得目前上傳的檔名 (之前上傳時暫存在 Tag 內)
                    string fileName = this.licensepictureBox.Tag.ToString();
                    // 將檔名存入 photo 欄位，供資料庫記錄
                    row["image_source"] = fileName;

                    // 產生目標儲存路徑
                    string storePath = Path.Combine(licenseImageFolderPath, fileName);
                    // 確認暫存上傳路徑有效，執行檔案複製進專屬資料夾中
                    if (!string.IsNullOrEmpty(selectedLicensePhotoFullPath) && File.Exists(selectedLicensePhotoFullPath))
                    {
                        File.Copy(selectedLicensePhotoFullPath, storePath, true);
                        selectedLicensePhotoFullPath = null;
                    }
                }
            }
            // 執行整體畫面驗證 (強制觸發所有控制項驗證機制)
            this.Validate();
            // 結束 BindingSource 編輯狀態，將 UI 變更同步回 DataRow
            licensebindingSource1.EndEdit();
            // 利用 TableAdapter 將離線 DataSet 變更回寫至資料庫
            licensesTableAdapter1.Update(t_ACDataSet1.licenses);

            MessageBox.Show("證照資料已儲存");
        }

        private void btnDeleteLicense_Click(object sender, EventArgs e)
        {
            if (licensebindingSource1.Current != null)
            {
                //將當前資料全部清掉
                licensebindingSource1.RemoveCurrent();
                MessageBox.Show("已刪除");
            }
            else
            {
                MessageBox.Show("目前沒有選取任何證照");
            }
        }
    }
}