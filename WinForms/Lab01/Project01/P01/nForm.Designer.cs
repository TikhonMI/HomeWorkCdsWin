﻿namespace P01
{
    partial class nForm
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
            checkBoxClose = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBoxClose
            // 
            checkBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxClose.AutoSize = true;
            checkBoxClose.Location = new Point(733, 12);
            checkBoxClose.Name = "checkBoxClose";
            checkBoxClose.Size = new Size(55, 19);
            checkBoxClose.TabIndex = 0;
            checkBoxClose.Text = "Close";
            checkBoxClose.UseVisualStyleBackColor = true;
            checkBoxClose.CheckedChanged += checkBoxClose_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBoxClose);
            Name = "nForm";
            Text = "nForm";
            FormClosing += nForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxClose;
        private Button button1;
    }
}