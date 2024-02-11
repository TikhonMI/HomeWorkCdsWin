namespace WinTimer1
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
            userControlTimer1 = new UserControlTimer();
            button1 = new Button();
            userControl11 = new WinFormsControlLibrary.UserControl1();
            SuspendLayout();
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(23, 11);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(58, 22);
            userControlTimer1.TabIndex = 0;
            userControlTimer1.TimeEnabled = true;
            // 
            // button1
            // 
            button1.Location = new Point(108, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(23, 31);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(58, 32);
            userControl11.TabIndex = 2;
            userControl11.TimeEnabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 70);
            Controls.Add(userControl11);
            Controls.Add(button1);
            Controls.Add(userControlTimer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Win Timer";
            ResumeLayout(false);
        }

        #endregion

        private UserControlTimer userControlTimer1;
        private Button button1;
        private WinFormsControlLibrary.UserControl1 userControl11;
    }
}