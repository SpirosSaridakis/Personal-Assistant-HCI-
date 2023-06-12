namespace EmailClient
{
    partial class EmailAccount
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 529);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 180);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "SMTP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 119);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "Port:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 91);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 54);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 7;
            label1.Text = "Username:";
            // 
            // button2
            // 
            button2.Location = new Point(208, 494);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(308, 494);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(290, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "SSL";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(92, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(310, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 27);
            textBox1.TabIndex = 0;
            // 
            // EmailAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 553);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(450, 600);
            MinimumSize = new Size(450, 600);
            Name = "EmailAccount";
            Text = "EmailAccount";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}