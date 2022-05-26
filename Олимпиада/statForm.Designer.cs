
namespace Олимпиада
{
    partial class statForm
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
            this.CountBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SumBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 75);
            this.dataGridView1.TabIndex = 0;
            // 
            // CountBtn
            // 
            this.CountBtn.Depth = 0;
            this.CountBtn.Location = new System.Drawing.Point(12, 146);
            this.CountBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Primary = true;
            this.CountBtn.Size = new System.Drawing.Size(210, 40);
            this.CountBtn.TabIndex = 1;
            this.CountBtn.Text = "Количество моих приложений";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // SumBtn
            // 
            this.SumBtn.Depth = 0;
            this.SumBtn.Location = new System.Drawing.Point(241, 146);
            this.SumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Primary = true;
            this.SumBtn.Size = new System.Drawing.Size(210, 40);
            this.SumBtn.TabIndex = 2;
            this.SumBtn.Text = "Общий размер приложений";
            this.SumBtn.UseVisualStyleBackColor = true;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // statForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 205);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "statForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cтатистика приложений";
            this.Load += new System.EventHandler(this.statForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton CountBtn;
        private MaterialSkin.Controls.MaterialRaisedButton SumBtn;
    }
}