namespace WorkWithWork.WinFormsApp
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
            button1 = new Button();
            writeBtn = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 72);
            button1.Name = "button1";
            button1.Size = new Size(143, 55);
            button1.TabIndex = 0;
            button1.Text = "Чтение файла";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // writeBtn
            // 
            writeBtn.Location = new Point(43, 212);
            writeBtn.Name = "writeBtn";
            writeBtn.Size = new Size(143, 49);
            writeBtn.TabIndex = 1;
            writeBtn.Text = "Запись в файл";
            writeBtn.UseVisualStyleBackColor = true;
            writeBtn.Click += writeBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(289, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(350, 232);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(writeBtn);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button writeBtn;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }
}
