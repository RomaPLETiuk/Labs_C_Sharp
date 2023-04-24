
namespace BasStation
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.Clode_this = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(332, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(269, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 35);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(322, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(269, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(234, 35);
            this.textBox2.TabIndex = 3;
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.DarkCyan;
            this.b_login.ForeColor = System.Drawing.Color.Cyan;
            this.b_login.Location = new System.Drawing.Point(269, 301);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(234, 29);
            this.b_login.TabIndex = 4;
            this.b_login.Text = "ВХІД";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // Clode_this
            // 
            this.Clode_this.AutoSize = true;
            this.Clode_this.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clode_this.ForeColor = System.Drawing.Color.Crimson;
            this.Clode_this.Location = new System.Drawing.Point(762, 9);
            this.Clode_this.Name = "Clode_this";
            this.Clode_this.Size = new System.Drawing.Size(26, 26);
            this.Clode_this.TabIndex = 5;
            this.Clode_this.Text = "Х";
            this.Clode_this.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(803, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "АРМ диспетчера руху автобусів. Розробник Плетюк Р. М. Всі права захищені!        " +
    "                                                ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clode_this);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "АРМ Диспетчера руху автобусів";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Label Clode_this;
        private System.Windows.Forms.Label label3;
    }
}

