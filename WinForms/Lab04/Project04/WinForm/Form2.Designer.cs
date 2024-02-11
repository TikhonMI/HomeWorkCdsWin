namespace WinForm
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
            textBoxF21 = new TextBox();
            textBoxF22 = new TextBox();
            textBoxF23 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxF21
            // 
            textBoxF21.Location = new Point(12, 12);
            textBoxF21.Name = "textBoxF21";
            textBoxF21.Size = new Size(100, 23);
            textBoxF21.TabIndex = 0;
            // 
            // textBoxF22
            // 
            textBoxF22.Location = new Point(12, 54);
            textBoxF22.Name = "textBoxF22";
            textBoxF22.Size = new Size(100, 23);
            textBoxF22.TabIndex = 1;
            // 
            // textBoxF23
            // 
            textBoxF23.Location = new Point(12, 95);
            textBoxF23.Name = "textBoxF23";
            textBoxF23.Size = new Size(100, 23);
            textBoxF23.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(25, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(126, 184);
            Controls.Add(button1);
            Controls.Add(textBoxF23);
            Controls.Add(textBoxF22);
            Controls.Add(textBoxF21);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxF21;
        private TextBox textBoxF22;
        private TextBox textBoxF23;
        private Button button1;
    }
}