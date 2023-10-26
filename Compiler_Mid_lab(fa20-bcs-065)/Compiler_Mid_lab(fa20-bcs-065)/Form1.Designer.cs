namespace Compiler_Mid_lab_fa20_bcs_065_
{
    partial class Form1
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
            tbInp = new TextBox();
            tbOut = new TextBox();
            parse = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Next = new Button();
            SuspendLayout();
            // 
            // tbInp
            // 
            tbInp.Location = new Point(251, 87);
            tbInp.Multiline = true;
            tbInp.Name = "tbInp";
            tbInp.Size = new Size(298, 99);
            tbInp.TabIndex = 0;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(251, 283);
            tbOut.Multiline = true;
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(311, 107);
            tbOut.TabIndex = 1;
            // 
            // parse
            // 
            parse.BackgroundImageLayout = ImageLayout.Stretch;
            parse.FlatStyle = FlatStyle.Popup;
            parse.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            parse.ForeColor = Color.OrangeRed;
            parse.Location = new Point(332, 225);
            parse.Name = "parse";
            parse.Size = new Size(121, 37);
            parse.TabIndex = 2;
            parse.Text = "Parse";
            parse.UseVisualStyleBackColor = true;
            parse.Click += parse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(332, 21);
            label1.Name = "label1";
            label1.Size = new Size(204, 24);
            label1.TabIndex = 3;
            label1.Text = "Qno:2 >>LL1 parsing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(110, 124);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 4;
            label2.Text = "Input Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 315);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 5;
            label3.Text = "output text";
            // 
            // Next
            // 
            Next.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Next.Location = new Point(655, 405);
            Next.Name = "Next";
            Next.Size = new Size(106, 33);
            Next.TabIndex = 6;
            Next.Text = "Next Form";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Next);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(parse);
            Controls.Add(tbOut);
            Controls.Add(tbInp);
            Name = "Form1";
            Text = "LL1 Parsing";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInp;
        private TextBox tbOut;
        private Button parse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Next;
    }
}