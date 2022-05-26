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
using System.Data.SqlClient;

namespace Олимпиада
{
    public partial class Registr : MaterialForm
    {

        AppContext db;
        public Registr()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            db = new AppContext();
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            if (TBemail.Text == "" || TBpass.Text == "" || TBpass2.Text == "") 
            {
                MessageBox.Show("Данные не заполнены!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TBpass.TextLength < 8)
            {
                label2.Text = "Нужно не менее 8 символов!";
                label2.Visible = true;
            }

            else if (TBpass.Text != TBpass2.Text)
            {
                label2.Text = "Пароли не совпадают!";
                label2.Visible = true;
            }

            else
            {
              
                    this.Close();
                    { MessageBox.Show("Регистрация прошла успешно!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    label2.Visible = false;

                    var email = TBemail.Text;
                    var password = TBpass.Text;
                    User user = new User(email, password);

                    db.Users.Add(user);
                    db.SaveChanges();
            }
            
        }


        private void Registr_Load(object sender, EventArgs e)
        {
            TBpass.UseSystemPasswordChar = true;
            pictureFalsePass1.Visible = false;
            picturetruPass1.Visible = true;

            TBpass2.UseSystemPasswordChar = true;
            pictureFalsePass2.Visible = false;
            picturetruPass2.Visible = true;


            TBemail.MaxLength = 50;
            TBpass.MaxLength = 50;
            TBpass2.MaxLength = 50;

           
            label2.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void picturetruPass1_Click(object sender, EventArgs e)
        {
            var truevisible = TBpass;
            truevisible.UseSystemPasswordChar = false;
            pictureFalsePass1.Visible = true;
            picturetruPass1.Visible = false;
        }

        private void pictureFalsePass1_Click(object sender, EventArgs e)
        {
            var falsevisible = TBpass;
            falsevisible.UseSystemPasswordChar = true;
            pictureFalsePass1.Visible = false;
            picturetruPass1.Visible = true;
        }

        private void picturetruPass2_Click(object sender, EventArgs e)
        {
            var truevisible = TBpass2;
            truevisible.UseSystemPasswordChar = false;
            pictureFalsePass2.Visible = true;
            picturetruPass2.Visible = false;
        }

        private void pictureFalsePass2_Click(object sender, EventArgs e)
        {
            var falsevisible = TBpass2;
            falsevisible.UseSystemPasswordChar = true;
            pictureFalsePass2.Visible = false;
            picturetruPass2.Visible = true;
        }
    }
}

