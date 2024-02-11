namespace ValidationForm
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
            userWalid1 = new UserWalid();
            numValid1 = new NumValid();
            button1 = new Button();
            SuspendLayout();
            // 
            // userWalid1
            // 
            userWalid1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userWalid1.Label = "Букавы";
            userWalid1.Latt = "";
            userWalid1.Location = new Point(12, 12);
            userWalid1.Name = "userWalid1";
            userWalid1.Size = new Size(228, 29);
            userWalid1.TabIndex = 0;
            // 
            // numValid1
            // 
            numValid1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numValid1.Label = "Цыферы";
            numValid1.Location = new Point(12, 47);
            numValid1.Name = "numValid1";
            numValid1.Numb = "";
            numValid1.Size = new Size(228, 29);
            numValid1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(12, 90);
            button1.Name = "button1";
            button1.Size = new Size(228, 28);
            button1.TabIndex = 2;
            button1.Text = "Кнопка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 130);
            Controls.Add(button1);
            Controls.Add(numValid1);
            Controls.Add(userWalid1);
            MinimumSize = new Size(268, 169);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validation";
            ResumeLayout(false);
        }

        #endregion

        private UserWalid userWalid1;
        private NumValid numValid1;
        private Button button1;
    }
}