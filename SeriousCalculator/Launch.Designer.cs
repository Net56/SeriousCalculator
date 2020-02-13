namespace SeriousCalculator
{
    partial class Launch
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.subTitleLbl1 = new System.Windows.Forms.Label();
            this.subTitleLbl2 = new System.Windows.Forms.Label();
            this.appSelectBox = new System.Windows.Forms.ComboBox();
            this.appGoBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Trebuchet MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(56, 44);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(476, 63);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Serious Application";
            // 
            // subTitleLbl1
            // 
            this.subTitleLbl1.AutoSize = true;
            this.subTitleLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLbl1.Location = new System.Drawing.Point(270, 147);
            this.subTitleLbl1.Name = "subTitleLbl1";
            this.subTitleLbl1.Size = new System.Drawing.Size(197, 17);
            this.subTitleLbl1.TabIndex = 1;
            this.subTitleLbl1.Text = "For all your applicating needs!";
            // 
            // subTitleLbl2
            // 
            this.subTitleLbl2.AutoSize = true;
            this.subTitleLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLbl2.Location = new System.Drawing.Point(371, 193);
            this.subTitleLbl2.Name = "subTitleLbl2";
            this.subTitleLbl2.Size = new System.Drawing.Size(249, 24);
            this.subTitleLbl2.TabIndex = 2;
            this.subTitleLbl2.Text = "Where would you like to go?";
            // 
            // appSelectBox
            // 
            this.appSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appSelectBox.FormattingEnabled = true;
            this.appSelectBox.Items.AddRange(new object[] {
            "Calculator"});
            this.appSelectBox.Location = new System.Drawing.Point(318, 275);
            this.appSelectBox.Name = "appSelectBox";
            this.appSelectBox.Size = new System.Drawing.Size(214, 24);
            this.appSelectBox.TabIndex = 3;
            // 
            // appGoBtn
            // 
            this.appGoBtn.Location = new System.Drawing.Point(560, 259);
            this.appGoBtn.Name = "appGoBtn";
            this.appGoBtn.Size = new System.Drawing.Size(145, 55);
            this.appGoBtn.TabIndex = 4;
            this.appGoBtn.Text = "Applicate!";
            this.appGoBtn.UseVisualStyleBackColor = true;
            this.appGoBtn.Click += new System.EventHandler(this.AppGoBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 259);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(145, 55);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Launch
            // 
            this.AcceptButton = this.appGoBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 326);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.appGoBtn);
            this.Controls.Add(this.appSelectBox);
            this.Controls.Add(this.subTitleLbl2);
            this.Controls.Add(this.subTitleLbl1);
            this.Controls.Add(this.titleLbl);
            this.Name = "Launch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label subTitleLbl1;
        private System.Windows.Forms.Label subTitleLbl2;
        private System.Windows.Forms.ComboBox appSelectBox;
        private System.Windows.Forms.Button appGoBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}