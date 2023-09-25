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
            this.rd8 = new System.Windows.Forms.RadioButton();
            this.rd16 = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rd8
            // 
            this.rd8.AutoSize = true;
            this.rd8.Location = new System.Drawing.Point(99, 159);
            this.rd8.Name = "rd8";
            this.rd8.Size = new System.Drawing.Size(31, 19);
            this.rd8.TabIndex = 1;
            this.rd8.TabStop = true;
            this.rd8.Text = "8";
            this.rd8.UseVisualStyleBackColor = true;
            // 
            // rd16
            // 
            this.rd16.AutoSize = true;
            this.rd16.Location = new System.Drawing.Point(99, 195);
            this.rd16.Name = "rd16";
            this.rd16.Size = new System.Drawing.Size(37, 19);
            this.rd16.TabIndex = 2;
            this.rd16.TabStop = true;
            this.rd16.Text = "16";
            this.rd16.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(286, 256);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(180, 23);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(286, 51);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(68, 23);
            this.txtInput.TabIndex = 6;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_number_KeyPress);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(99, 256);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 7;
            this.btnAnswer.Text = "Ответ";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.Location = new System.Drawing.Point(99, 51);
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.Size = new System.Drawing.Size(75, 23);
            this.btnRandomNumber.TabIndex = 8;
            this.btnRandomNumber.Text = "Загадать кнопку";
            this.btnRandomNumber.UseVisualStyleBackColor = true;
            this.btnRandomNumber.Click += new System.EventHandler(this.btnRandomNumber_Click);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(99, 122);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(31, 19);
            this.rd2.TabIndex = 9;
            this.rd2.TabStop = true;
            this.rd2.Text = "2";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.rd16);
            this.Controls.Add(this.rd8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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