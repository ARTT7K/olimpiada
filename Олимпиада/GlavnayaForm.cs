using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Олимпиада
{
    public partial class GlavnayaForm : MaterialForm
    {
        public GlavnayaForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_command;
        private SQLiteDataAdapter db;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        private void GlavnayaForm_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 180;
            
        }

        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=BD.db;Version=3;New=false;Compress=true;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_command = sql_con.CreateCommand();
            sql_command.CommandText = txtQuery;
            sql_command.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_command = sql_con.CreateCommand();
            string CommandText = "select * from Apps";
            db = new SQLiteDataAdapter(CommandText, sql_con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            sql_con.Close();
        }

        private void NameAppsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //clear
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и удаление
            {
                MessageBox.Show("Данное поле не может содержать буквы и другие символы", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = NameAppsTB.Text;
            string lvl = comboBox1.Text;
            string size = SizeAppTB.Text;

            if (NameAppsTB.Text == "" || comboBox1.Text == "" || SizeAppTB.Text == "")
            {
                MessageBox.Show("Данные не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string txtQuery = "insert into Apps (Название, Стадия, Размер)values('" + name + "', '" + lvl + "', '" + size + "')";
                ExecuteQuery(txtQuery);
                LoadData();
            }
        }

      

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Apps where ID='" + idTB.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            statForm stat = new statForm();
            stat.Show();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            var close = MessageBox.Show("Действительно хотите выйти?", "ВНИМАНИЕ!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
                this.Close();
        }
    }

    

   
}

