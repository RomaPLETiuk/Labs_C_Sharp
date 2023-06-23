namespace BusST
{
    partial class NewBus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Nomer = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.C_Seat = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код Автобуса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Модель/марка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Рік випуску";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номерний знак";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Кількість місць";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(258, 114);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(189, 25);
            this.Number.TabIndex = 7;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(258, 172);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(189, 25);
            this.Model.TabIndex = 8;
            // 
            // Nomer
            // 
            this.Nomer.Location = new System.Drawing.Point(258, 237);
            this.Nomer.Name = "Nomer";
            this.Nomer.Size = new System.Drawing.Size(189, 25);
            this.Nomer.TabIndex = 9;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(258, 290);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(189, 25);
            this.Year.TabIndex = 10;
            // 
            // C_Seat
            // 
            this.C_Seat.Location = new System.Drawing.Point(258, 355);
            this.C_Seat.Name = "C_Seat";
            this.C_Seat.Size = new System.Drawing.Size(189, 25);
            this.C_Seat.TabIndex = 11;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Add.Location = new System.Drawing.Point(258, 401);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(134, 37);
            this.Add.TabIndex = 12;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(258, 61);
            this.maskedTextBox1.Mask = "BUS000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(189, 25);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(399, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(502, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.C_Seat);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Nomer);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новий автобус";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Nomer;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox C_Seat;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
    }
}