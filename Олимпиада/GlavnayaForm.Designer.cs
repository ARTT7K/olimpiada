
namespace Олимпиада
{
    partial class GlavnayaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NameAppsTB = new System.Windows.Forms.TextBox();
            this.SizeAppTB = new System.Windows.Forms.TextBox();
            this.btnReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deletebtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Closebtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(72, 463);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(312, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить приложение в список";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NameAppsTB
            // 
            this.NameAppsTB.Location = new System.Drawing.Point(96, 522);
            this.NameAppsTB.Name = "NameAppsTB";
            this.NameAppsTB.Size = new System.Drawing.Size(100, 20);
            this.NameAppsTB.TabIndex = 2;
            this.NameAppsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameAppsTB_KeyPress);
            // 
            // SizeAppTB
            // 
            this.SizeAppTB.Location = new System.Drawing.Point(157, 574);
            this.SizeAppTB.Name = "SizeAppTB";
            this.SizeAppTB.Size = new System.Drawing.Size(100, 20);
            this.SizeAppTB.TabIndex = 4;
            this.SizeAppTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnReport
            // 
            this.btnReport.Depth = 0;
            this.btnReport.Location = new System.Drawing.Point(72, 424);
            this.btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport.Name = "btnReport";
            this.btnReport.Primary = true;
            this.btnReport.Size = new System.Drawing.Size(312, 33);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Просмотр статистики";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стадия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Размер(МБ):";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "В разработке",
            "Разработано"});
            this.comboBox1.Location = new System.Drawing.Point(224, 522);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(370, 546);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(42, 20);
            this.idTB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID:";
            // 
            // deletebtn
            // 
            this.deletebtn.Depth = 0;
            this.deletebtn.Location = new System.Drawing.Point(342, 572);
            this.deletebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Primary = true;
            this.deletebtn.Size = new System.Drawing.Size(109, 22);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Depth = 0;
            this.Closebtn.Location = new System.Drawing.Point(12, 572);
            this.Closebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Primary = true;
            this.Closebtn.Size = new System.Drawing.Size(109, 22);
            this.Closebtn.TabIndex = 13;
            this.Closebtn.Text = "Выход";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // GlavnayaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 600);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.SizeAppTB);
            this.Controls.Add(this.NameAppsTB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GlavnayaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма созданных приложений";
            this.Load += new System.EventHandler(this.GlavnayaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.TextBox NameAppsTB;
        private System.Windows.Forms.TextBox SizeAppTB;
        private MaterialSkin.Controls.MaterialRaisedButton btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton deletebtn;
        private MaterialSkin.Controls.MaterialRaisedButton Closebtn;
    }
}