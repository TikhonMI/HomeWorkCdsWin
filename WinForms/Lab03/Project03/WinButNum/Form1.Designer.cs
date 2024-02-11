namespace WinButNum
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
            clickButton1 = new ClickButton();
            SuspendLayout();
            // 
            // clickButton1
            // 
            clickButton1.Location = new Point(37, 26);
            clickButton1.Name = "clickButton1";
            clickButton1.Size = new Size(98, 51);
            clickButton1.TabIndex = 0;
            clickButton1.Text = "clickButton1";
            clickButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(175, 105);
            Controls.Add(clickButton1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Win But Num";
            ResumeLayout(false);
        }

        #endregion

        private ClickButton clickButton1;
    }
}