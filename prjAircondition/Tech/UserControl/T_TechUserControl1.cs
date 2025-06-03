using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjAircondition.Tech.DataSet;

namespace prjAircondition.Tech
{
    public partial class T_TechUserControl1 : UserControl
    {
        //傳進來的師傅編號

        public string TechloginAccount { get; set; }

        private string connString = "Data Source=.;Initial Catalog=AC;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=True;Trust Server Certificate=True";

        private string imageFolderPath; // 圖片存放位置

        public T_TechUserControl1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;

            bindingSource1.DataSource = t_ACDataSet;
            bindingSource1.DataMember = "Technicians";
            SetDateTimePickers();

            //C:\Tech\prjAircondition\bin\Debug 調整位置
            //指定檔案位置

            string projectRootPath = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
            imageFolderPath = Path.Combine(projectRootPath, "TechResources");
            Directory.CreateDirectory(imageFolderPath);
        }

        private void TechUserControl1_Load(object sender, EventArgs e)
        {
            //先把該帳號資訊傳入 帳號文字輸入框裡面
            techAccountTextBox.Text = TechloginAccount;

            // 設定 BindingSource
            bindingSource1.DataSource = this.t_ACDataSet.Technicians;

            // 這裡直接幫你做 DataBindings
            this.techniciansTableAdapter1.FillByAccount(this.t_ACDataSet.Technicians, TechloginAccount);
            userNameTextBox.DataBindings.Add("Text", bindingSource1, "name");
            phone_textBox.DataBindings.Add("Text", bindingSource1, "phone");
            NickNameTextBox.DataBindings.Add("Text", bindingSource1, "NickName");
            techAccountTextBox.DataBindings.Add("Text", bindingSource1, "account");

            // 綁定「建立時間」，只能讀取，使用者不能改
            createdAtPicker.DataBindings.Add(
                "Value",
                bindingSource1,
                "created_at",
                true,
                DataSourceUpdateMode.Never
            );

            // 綁定「更新時間」，也是讀取用，改動放在 Save 時程式裡
            updatedAtPicker.DataBindings.Add(
                "Value",
                bindingSource1,
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

            LoadImageFromDS();
        }

        //離線資料庫載入
        private void LoadImageFromDS()
        {
            if (this.t_ACDataSet.Technicians.Rows.Count > 0)
            {
                DataRow row = t_ACDataSet.Technicians.Rows[0];

                if (!row.IsNull("photo") && !string.IsNullOrWhiteSpace(row["photo"].ToString()))
                {
                    string filename = row["photo"].ToString();
                    string fullPath = Path.Combine(imageFolderPath, filename);

                    if (File.Exists(fullPath))
                    {
                        pictureBox1.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        LoadDefaultImage();
                    }
                }
                else
                {
                    LoadDefaultImage();
                }
            }
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
            MessageBox.Show("Application.StartupPath: " + Application.StartupPath);

            if (File.Exists(defaultPath))
            {
                pictureBox1.Image = Image.FromFile(defaultPath);
            }
            else
            {
                pictureBox1.Image = null; // 沒預設圖就空白
            }
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

        //open Photo file
        private void button2_Click(object sender, EventArgs e)
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

                // 顯示圖片存到p1 BOX
                this.pictureBox1.Image = Image.FromFile(destPath);

                // 把這個TAG給值 為目前所選檔案名稱
                this.pictureBox1.Tag = fileName;
                MessageBox.Show($"已上傳 {fileName}");
            }
            else
            {
                MessageBox.Show("取消");
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
            if (bindingSource1.Current is DataRowView drv)
            {
                DataRow row = drv.Row;
                //只對update_at欄位更新資料
                row["updated_at"] = DateTime.Now;

                //Tag有值傳回資料庫
                if (this.pictureBox1.Tag != null)
                {
                    string selectedPhotoFileName = pictureBox1.Tag.ToString();
                    row["photo"] = selectedPhotoFileName;
                }
            }

            //確保輸入資料驗證正確 TextBox內容
            this.Validate();
            //編輯的資料寫回到 BindingSource 裡面的 DataSet
            this.bindingSource1.EndEdit();
            //記憶體內 DataSet 資料更新同步寫回資料庫
            object value = this.techniciansTableAdapter1.Update(this.t_ACDataSet.Technicians);
            MessageBox.Show("成功修改");
        }

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

                // 顯示圖片存到p1 BOX
                this.pictureBox1.Image = Image.FromFile(destPath);

                // 把這個TAG給值 為目前所選檔案名稱
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