namespace WinAsynchMethod
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
            lblA = new Label();
            lblB = new Label();
            txbA = new TextBox();
            txbB = new TextBox();
            btnRun = new Button();
            btnWork = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 31);
            lblA.Name = "lblA";
            lblA.Size = new Size(71, 15);
            lblA.TabIndex = 0;
            lblA.Text = "Значение А";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(207, 31);
            lblB.Name = "lblB";
            lblB.Size = new Size(70, 15);
            lblB.TabIndex = 1;
            lblB.Text = "Значение В";
            // 
            // txbA
            // 
            txbA.Location = new Point(89, 28);
            txbA.Name = "txbA";
            txbA.Size = new Size(100, 23);
            txbA.TabIndex = 2;
            // 
            // txbB
            // 
            txbB.Location = new Point(283, 28);
            txbB.Name = "txbB";
            txbB.Size = new Size(100, 23);
            txbB.TabIndex = 3;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(21, 78);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 4;
            btnRun.Text = "Сумма";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnWork
            // 
            btnWork.Location = new Point(168, 114);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(75, 23);
            btnWork.TabIndex = 5;
            btnWork.Text = "Работа";
            btnWork.UseVisualStyleBackColor = true;
            btnWork.Click += btnWork_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 161);
            Controls.Add(btnWork);
            Controls.Add(btnRun);
            Controls.Add(txbB);
            Controls.Add(txbA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Асинхронный запуск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private TextBox txbA;
        private TextBox txbB;
        private Button btnRun;
        private Button btnWork;
    }
}