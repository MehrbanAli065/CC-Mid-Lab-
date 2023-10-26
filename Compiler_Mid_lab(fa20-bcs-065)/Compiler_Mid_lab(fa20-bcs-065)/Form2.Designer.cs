namespace Compiler_Mid_lab_fa20_bcs_065_
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            tbName = new TextBox();
            tbLN = new TextBox();
            tbREG = new TextBox();
            tbOUT = new TextBox();
            G_Pass = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(26, 537);
            button1.Name = "button1";
            button1.Size = new Size(104, 37);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(299, 33);
            label1.Name = "label1";
            label1.Size = new Size(386, 36);
            label1.TabIndex = 1;
            label1.Text = "Qno#3 Password generator";
            // 
            // tbName
            // 
            tbName.Location = new Point(251, 119);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(187, 31);
            tbName.TabIndex = 2;
            // 
            // tbLN
            // 
            tbLN.Location = new Point(251, 202);
            tbLN.Multiline = true;
            tbLN.Name = "tbLN";
            tbLN.Size = new Size(187, 34);
            tbLN.TabIndex = 3;
            // 
            // tbREG
            // 
            tbREG.Location = new Point(251, 289);
            tbREG.Multiline = true;
            tbREG.Name = "tbREG";
            tbREG.Size = new Size(187, 32);
            tbREG.TabIndex = 4;
            // 
            // tbOUT
            // 
            tbOUT.Location = new Point(359, 424);
            tbOUT.Multiline = true;
            tbOUT.Name = "tbOUT";
            tbOUT.Size = new Size(283, 106);
            tbOUT.TabIndex = 5;
            // 
            // G_Pass
            // 
            G_Pass.BackColor = Color.FromArgb(255, 128, 128);
            G_Pass.FlatStyle = FlatStyle.Popup;
            G_Pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            G_Pass.ForeColor = Color.Black;
            G_Pass.Location = new Point(539, 198);
            G_Pass.Name = "G_Pass";
            G_Pass.Size = new Size(235, 57);
            G_Pass.TabIndex = 6;
            G_Pass.Text = "Generate Password";
            G_Pass.UseVisualStyleBackColor = false;
            G_Pass.Click += G_Pass_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 119);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 7;
            label2.Text = "NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 206);
            label3.Name = "label3";
            label3.Size = new Size(138, 30);
            label3.TabIndex = 8;
            label3.Text = "LAST NAME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 291);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 9;
            label4.Text = "REG NO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(395, 378);
            label5.Name = "label5";
            label5.Size = new Size(212, 30);
            label5.TabIndex = 10;
            label5.Text = "Generated Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(551, 157);
            label6.Name = "label6";
            label6.Size = new Size(208, 19);
            label6.TabIndex = 11;
            label6.Text = "Click here to genrate password";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 586);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(G_Pass);
            Controls.Add(tbOUT);
            Controls.Add(tbREG);
            Controls.Add(tbLN);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Passowrd generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox tbName;
        private TextBox tbLN;
        private TextBox tbREG;
        private TextBox tbOUT;
        private Button G_Pass;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}