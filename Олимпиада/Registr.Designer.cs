
namespace Олимпиада
{
    partial class Registr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr));
            this.TBemail = new System.Windows.Forms.TextBox();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.TBpass2 = new System.Windows.Forms.TextBox();
            this.btnRegistr = new MaterialSkin.Controls.MaterialRaisedButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passLabel2 = new System.Windows.Forms.Label();
            this.picturetruPass1 = new System.Windows.Forms.PictureBox();
            this.pictureFalsePass1 = new System.Windows.Forms.PictureBox();
            this.picturetruPass2 = new System.Windows.Forms.PictureBox();
            this.pictureFalsePass2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturetruPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFalsePass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturetruPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFalsePass2)).BeginInit();
            this.SuspendLayout();
            // 
            // TBemail
            // 
            this.TBemail.Location = new System.Drawing.Point(135, 122);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(128, 20);
            this.TBemail.TabIndex = 0;
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(135, 174);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(128, 20);
            this.TBpass.TabIndex = 1;
            // 
            // TBpass2
            // 
            this.TBpass2.Location = new System.Drawing.Point(135, 228);
            this.TBpass2.Name = "TBpass2";
            this.TBpass2.Size = new System.Drawing.Size(128, 20);
            this.TBpass2.TabIndex = 2;
            // 
            // btnRegistr
            // 
            this.btnRegistr.Depth = 0;
            this.btnRegistr.Location = new System.Drawing.Point(97, 254);
            this.btnRegistr.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Primary = true;
            this.btnRegistr.Size = new System.Drawing.Size(201, 47);
            this.btnRegistr.TabIndex = 3;
            this.btnRegistr.Text = "Зарегистрироваться";
            this.btnRegistr.UseVisualStyleBackColor = true;
            this.btnRegistr.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.linkLabel1.Location = new System.Drawing.Point(127, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Уже есть аккаунт? Войти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.emailLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.emailLabel.Location = new System.Drawing.Point(132, 101);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 19);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Почта:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.SystemColors.Window;
            this.passLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.passLabel.Location = new System.Drawing.Point(132, 152);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(63, 19);
            this.passLabel.TabIndex = 13;
            this.passLabel.Text = "Пароль:";
            // 
            // passLabel2
            // 
            this.passLabel2.AutoSize = true;
            this.passLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.passLabel2.Font = new System.Drawing.Font("Calibri", 12F);
            this.passLabel2.Location = new System.Drawing.Point(132, 206);
            this.passLabel2.Name = "passLabel2";
            this.passLabel2.Size = new System.Drawing.Size(136, 19);
            this.passLabel2.TabIndex = 14;
            this.passLabel2.Text = "Повторите пароль:";
            // 
            // picturetruPass1
            // 
            this.picturetruPass1.BackColor = System.Drawing.SystemColors.Control;
            this.picturetruPass1.Image = ((System.Drawing.Image)(resources.GetObject("picturetruPass1.Image")));
            this.picturetruPass1.Location = new System.Drawing.Point(241, 176);
            this.picturetruPass1.Name = "picturetruPass1";
            this.picturetruPass1.Size = new System.Drawing.Size(19, 16);
            this.picturetruPass1.TabIndex = 15;
            this.picturetruPass1.TabStop = false;
            this.picturetruPass1.Click += new System.EventHandler(this.picturetruPass1_Click);
            // 
            // pictureFalsePass1
            // 
            this.pictureFalsePass1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureFalsePass1.Image = ((System.Drawing.Image)(resources.GetObject("pictureFalsePass1.Image")));
            this.pictureFalsePass1.Location = new System.Drawing.Point(241, 177);
            this.pictureFalsePass1.Name = "pictureFalsePass1";
            this.pictureFalsePass1.Size = new System.Drawing.Size(19, 16);
            this.pictureFalsePass1.TabIndex = 16;
            this.pictureFalsePass1.TabStop = false;
            this.pictureFalsePass1.Click += new System.EventHandler(this.pictureFalsePass1_Click);
            // 
            // picturetruPass2
            // 
            this.picturetruPass2.BackColor = System.Drawing.SystemColors.Control;
            this.picturetruPass2.Image = ((System.Drawing.Image)(resources.GetObject("picturetruPass2.Image")));
            this.picturetruPass2.Location = new System.Drawing.Point(241, 230);
            this.picturetruPass2.Name = "picturetruPass2";
            this.picturetruPass2.Size = new System.Drawing.Size(19, 16);
            this.picturetruPass2.TabIndex = 17;
            this.picturetruPass2.TabStop = false;
            this.picturetruPass2.Click += new System.EventHandler(this.picturetruPass2_Click);
            // 
            // pictureFalsePass2
            // 
            this.pictureFalsePass2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureFalsePass2.Image = ((System.Drawing.Image)(resources.GetObject("pictureFalsePass2.Image")));
            this.pictureFalsePass2.Location = new System.Drawing.Point(241, 231);
            this.pictureFalsePass2.Name = "pictureFalsePass2";
            this.pictureFalsePass2.Size = new System.Drawing.Size(19, 16);
            this.pictureFalsePass2.TabIndex = 18;
            this.pictureFalsePass2.TabStop = false;
            this.pictureFalsePass2.Click += new System.EventHandler(this.pictureFalsePass2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(266, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пароли не совпадают!";
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureFalsePass2);
            this.Controls.Add(this.picturetruPass2);
            this.Controls.Add(this.pictureFalsePass1);
            this.Controls.Add(this.picturetruPass1);
            this.Controls.Add(this.passLabel2);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnRegistr);
            this.Controls.Add(this.TBpass2);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBemail);
            this.Name = "Registr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";
            this.Load += new System.EventHandler(this.Registr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturetruPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFalsePass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturetruPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFalsePass2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.TextBox TBpass2;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistr;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label passLabel2;
        private System.Windows.Forms.PictureBox picturetruPass1;
        private System.Windows.Forms.PictureBox pictureFalsePass1;
        private System.Windows.Forms.PictureBox picturetruPass2;
        private System.Windows.Forms.PictureBox pictureFalsePass2;
        private System.Windows.Forms.Label label2;
    }
}