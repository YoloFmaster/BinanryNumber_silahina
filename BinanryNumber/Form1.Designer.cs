namespace BinanryNumber
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
            rd8 = new RadioButton();
            rd16 = new RadioButton();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            btnAnswer = new Button();
            btnRandomNumber = new Button();
            rd2 = new RadioButton();
            SuspendLayout();
            // 
            // rd8
            // 
            rd8.AutoSize = true;
            rd8.Location = new Point(113, 212);
            rd8.Margin = new Padding(3, 4, 3, 4);
            rd8.Name = "rd8";
            rd8.Size = new Size(38, 24);
            rd8.TabIndex = 1;
            rd8.TabStop = true;
            rd8.Text = "8";
            rd8.UseVisualStyleBackColor = true;
            // 
            // rd16
            // 
            rd16.AutoSize = true;
            rd16.Location = new Point(113, 260);
            rd16.Margin = new Padding(3, 4, 3, 4);
            rd16.Name = "rd16";
            rd16.Size = new Size(46, 24);
            rd16.TabIndex = 2;
            rd16.TabStop = true;
            rd16.Text = "16";
            rd16.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(327, 341);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(465, 27);
            txtOutput.TabIndex = 5;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(327, 68);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(77, 27);
            txtInput.TabIndex = 6;
            txtInput.TextChanged += txtInput_TextChanged;
            txtInput.KeyPress += textBox_number_KeyPress;
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(113, 341);
            btnAnswer.Margin = new Padding(3, 4, 3, 4);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(86, 31);
            btnAnswer.TabIndex = 7;
            btnAnswer.Text = "Ответ";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnRandomNumber
            // 
            btnRandomNumber.Location = new Point(113, 68);
            btnRandomNumber.Margin = new Padding(3, 4, 3, 4);
            btnRandomNumber.Name = "btnRandomNumber";
            btnRandomNumber.Size = new Size(86, 31);
            btnRandomNumber.TabIndex = 8;
            btnRandomNumber.Text = "Загадать кнопку";
            btnRandomNumber.UseVisualStyleBackColor = true;
            btnRandomNumber.Click += btnRandomNumber_Click;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(113, 163);
            rd2.Margin = new Padding(3, 4, 3, 4);
            rd2.Name = "rd2";
            rd2.Size = new Size(38, 24);
            rd2.TabIndex = 9;
            rd2.TabStop = true;
            rd2.Text = "2";
            rd2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(rd2);
            Controls.Add(btnRandomNumber);
            Controls.Add(btnAnswer);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Controls.Add(rd16);
            Controls.Add(rd8);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rd8;
        private RadioButton rd16;
        private TextBox txtOutput;
        private TextBox txtInput;
        private Button btnAnswer;
        private Button btnRandomNumber;
        private RadioButton rd2;
    }
}