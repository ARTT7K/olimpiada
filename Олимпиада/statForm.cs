using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Олимпиада
{
    public partial class statForm : MaterialForm
    {
        public statForm()
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

        private void statForm_Load(object sender, EventArgs e)
        {
            
            /*LoadData();*/
            

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
            string CommandText = "SELECT SUM(Размер) FROM Apps ";
            db = new SQLiteDataAdapter(CommandText, sql_con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            sql_con.Close();
        }

        private void LoadData2()
        {
            SetConnection();
            sql_con.Open();
            sql_command = sql_con.CreateCommand();
            string CommandText = "SELECT Count(Название) FROM Apps ";
            db = new SQLiteDataAdapter(CommandText, sql_con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            sql_con.Close();
        }



        private void SumBtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "SELECT SUM(Размер) FROM Apps";
            ExecuteQuery(txtQuery);
            LoadData();
            dataGridView1.Columns[0].Width = 409;
            dataGridView1.Columns[0].HeaderText = "Общий размер приложений(в мегабайтах)";
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "SELECT COUNT(Название) FROM Apps";
            ExecuteQuery(txtQuery);
            LoadData2();
            dataGridView1.Columns[0].Width = 409;
            dataGridView1.Columns[0].HeaderText = "Количество ваших приложений:";
        }
    }
}
