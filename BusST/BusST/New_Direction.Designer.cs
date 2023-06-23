namespace BusST
{
    partial class New_Direction
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
            this.Code_Dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.TextBox();
            this.comboBox_codeDist = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Code_Dir
            // 
            this.Code_Dir.Location = new System.Drawing.Point(314, 70);
            this.Code_Dir.Name = "Code_Dir";
            this.Code_Dir.Size = new System.Drawing.Size(151, 25);
            this.Code_Dir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код напрямку";
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(314, 142);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(151, 25);
            this.Destination.TabIndex = 2;
            // 
            // comboBox_codeDist
            // 
            this.comboBox_codeDist.FormattingEnabled = true;
            this.comboBox_codeDist.Location = new System.Drawing.Point(314, 221);
            this.comboBox_codeDist.Name = "comboBox_codeDist";
            this.comboBox_codeDist.Size = new System.Drawing.Size(151, 25);
            this.comboBox_codeDist.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(314, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пункт призначення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Район";
            // 
            // New_Direction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(573, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_codeDist);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code_Dir);
            this.Name = "New_Direction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новий напрямок";
            this.Load += new System.EventHandler(this.New_Direction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Code_Dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.ComboBox comboBox_codeDist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}