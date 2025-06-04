using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters;
using prjAircondition.Tech.DataSet;
using prjAircondition.Dicuss.DataSet;
using System.IO;

namespace prjAircondition
{
    public partial class FormTech : Form
    {
        private string imageFolderPath;

        public FormTech()
        {
            InitializeComponent();
        }

        public FormTech(T_ACDataSet1 sharedDataSet)
        {
            InitializeComponent();

            // 不重新 Fill，直接和T_TechUserControl1共享一份離線資料表
            this.t_ACDataSet11 = sharedDataSet;

            this.techbindingSource1.DataSource = this.t_ACDataSet11.Technicians;
            BindUI();
            InitImageFolder();
            SetDateTimePickers();
            AddNewEmptyRow();
        }

        //進入畫面時預設新增最新一筆資料 裡面欄位都是空的
        // 進入畫面時預設新增一筆
        private void AddNewEmptyRow()
        {
            var newRowView = (DataRowView)this.techbindingSource1.AddNew();
            newRowView["created_at"] = DBNull.Value;
            newRowView["updated_at"] = DBNull.Value;

            createdAtPicker.Visible = false;
            updatedAtPicker.Visible = false;
        }

        private void FormTech_Load(object sender, EventArgs e)
        {
            //畫面顯示之後再執行
            this.BeginInvoke(new Action(() =>
            {
                LoadImageFromDS();
            }));
        }

        private void BindUI()
        {
            userNameTextBox.DataBindings.Add("Text", techbindingSource1, "name");
            NickNameTextBox.DataBindings.Add("Text", techbindingSource1, "NickName");
            phone_textBox.DataBindings.Add("Text", techbindingSource1, "phone");
            techAccountTextBox.DataBindings.Add("Text", techbindingSource1, "account");
            PasswordtextBox.DataBindings.Add("Text", techbindingSource1, "password");
            AddresstextBox.DataBindings.Add("Text", techbindingSource1, "address");
            emailTextBox.DataBindings.Add("Text", techbindingSource1, "email");

            //DataSourceUpdateMode.Never
            // 綁定「建立時間」，只能讀取，使用者不能改
            createdAtPicker.DataBindings.Add(
                "Value",
                this.techbindingSource1,
                "created_at",
                true,
               DataSourceUpdateMode.Never
            );

            // 綁定「更新時間」，也是讀取用，改動放在 Save 時程式裡
            updatedAtPicker.DataBindings.Add(
                "Value",
                this.techbindingSource1,
                "updated_at",
                true,
                DataSourceUpdateMode.Never
            );

            // 以下部分，是把 gender 改成 SelectedValue 雙向綁定
            // 先把 ComboBox 放選項（「男生/女生」對應 bool）
            cmdGender.Items.Clear();
            cmdGender.DataSource = null; // 先確保沒有舊的 DataSource
            InitGenderComboBox();          // 塞入「男生」「女生」+ ValueMember=Key, DisplayMember=Value

            // 這一行改成 SelectedValue，對應到資料集裡的 gender 欄位（bool）
            cmdGender.DataBindings.Add(
                "SelectedValue",
                techbindingSource1,
                "gender",
                true,
                DataSourceUpdateMode.OnPropertyChanged
            );
        }

        private void InitGenderComboBox()
        {
            // List 內容：Key = bit 欄位對應的 bool 值；Value = 顯示用的文字
            var genderSource = new List<KeyValuePair<bool, string>>()
        {
            new KeyValuePair<bool, string>(false, "男生"),
            new KeyValuePair<bool, string>(true,  "女生")
        };

            // 指定 ComboBox 的 DataSource、DisplayMember、ValueMember
            cmdGender.DataSource = genderSource;
            cmdGender.DisplayMember = "Value"; // 顯示「男生」「女生」
            cmdGender.ValueMember = "Key";   // 真正對應到後端資料的 bool 值
        }

        private void SetDateTimePickers()
        {
            // 針對「建立時間」DateTimePicker 做設定
            createdAtPicker.Format = DateTimePickerFormat.Custom;
            createdAtPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            createdAtPicker.Enabled = false; // 讓使用者不能手動改

            // 針對「更新時間」DateTimePicker 做設定 幾時幾分幾秒
            updatedAtPicker.Format = DateTimePickerFormat.Custom;
            updatedAtPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            updatedAtPicker.Enabled = false; // 讓使用者不能手動改
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
            if (this.techbindingSource1.Current is DataRowView drv)
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
            //給預設照片 都在 C:\Tech\prjAircondition\Tech\TechResources底下
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

        //建立暫存
        private void btnAddTemp_Click(object sender, EventArgs e)
        {
            //DataRow newRow = t_ACDataSet11.Technicians.NewRow();

            //移動到最後一筆
            techbindingSource1.MoveLast();

            // 新增時仍隱藏時間
            createdAtPicker.Visible = false;
            updatedAtPicker.Visible = false;
            MessageBox.Show("已暫存，尚待存回資料庫");
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (techbindingSource1.Current == null)
            {
                MessageBox.Show("目前沒有可更新的資料");
                return;
            }

            // 取目前資料行
            DataRowView currentRowView = (DataRowView)techbindingSource1.Current;

            //檢查這筆資料 是不是有創立過了
            bool isNew = (currentRowView["created_at"] == DBNull.Value);
            DateTime now = DateTime.Now;

            if (isNew)
            {
                // 第一次存檔
                currentRowView["created_at"] = now;
                currentRowView["updated_at"] = now;
            }
            else
            {
                // 之後只更新 updated_at
                currentRowView["updated_at"] = now;
            }

            // 讓時間欄位出現
            createdAtPicker.Value = Convert.ToDateTime(currentRowView["created_at"]);
            updatedAtPicker.Value = Convert.ToDateTime(currentRowView["updated_at"]);
            createdAtPicker.Visible = true;
            updatedAtPicker.Visible = true;

            // 存回資料庫
            this.Validate();
            techbindingSource1.EndEdit();
            techniciansTableAdapter1.Update(t_ACDataSet11.Technicians);

            // 先確認目前 techniciansBindingSource 指向哪一筆資料
            if (this.techbindingSource1.Current is DataRowView dataRowView)
            {
                //先把dataRowView轉換成datarow 那筆資料列再去拿欄位內容的值
                DataRow dataRow = dataRowView.Row;

                //照片有更動時，更新photo欄位內容
                if (this.pictureBox1.Tag != null)
                {
                    //把那筆資料列欄位換成這個Tag名稱
                    string fileName = this.pictureBox1.Tag.ToString();
                    dataRow["photo"] = fileName;

                    //儲存時複製一份檔案到資料夾裡 路徑
                    string storePath = Path.Combine(imageFolderPath, fileName);

                    // 檢查來源路徑是否有效，才進行檔案複製
                    if (!string.IsNullOrEmpty(selectedPhotoFullPath) && File.Exists(selectedPhotoFullPath))
                    {
                        // 避免重複覆蓋同名檔案 複製一份檔案到這路徑storePath下
                        // true 代表有同名檔案時覆蓋
                        File.Copy(selectedPhotoFullPath, storePath, true);
                        selectedPhotoFullPath = null;
                    }
                }
            }

            MessageBox.Show("資料已更新");
        }

        private string selectedPhotoFullPath = null;

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            //假如有照片上傳的路就 先初始化   upDate回去時再複製一份推送回DB
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
    }
}