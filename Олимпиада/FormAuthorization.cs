using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Олимпиада
{
    public partial class FormAuthorization : MaterialForm
    {
        /*DataBase dataBase = new DataBase();*/
        public FormAuthorization()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            TBpassword.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            TBlogin.MaxLength = 50;
            TBpassword.MaxLength = 50;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var falsevisible = TBpassword;
            falsevisible.UseSystemPasswordChar = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var truevisible = TBpassword;
            truevisible.UseSystemPasswordChar = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if (TBlogin.Text == "" || TBpassword.Text == "") { MessageBox.Show("Поля не заполнены!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            else
            {
                var email = TBlogin.Text;
                var password = TBpassword.Text;

                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    authUser = db.Users.Where(b => b.Email == email && b.Password == password).FirstOrDefault();
                }

                if (authUser != null)

                {
                    MessageBox.Show("Авторизация прошла успешно!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlavnayaForm gf = new GlavnayaForm();
                    gf.Show();
                }
                
                else { MessageBox.Show("Неверный пароль или почта!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registr form = new Registr();
            form.ShowDialog();
        }
    }
   
    }

