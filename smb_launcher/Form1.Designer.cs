namespace smb_launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HighDetail = new System.Windows.Forms.Button();
            this.LowDetail = new System.Windows.Forms.Button();
            this.UltraLowDetail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Savegame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HighDetail
            // 
            this.HighDetail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighDetail.Location = new System.Drawing.Point(6, 19);
            this.HighDetail.Name = "HighDetail";
            this.HighDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HighDetail.Size = new System.Drawing.Size(75, 23);
            this.HighDetail.TabIndex = 0;
            this.HighDetail.Text = "High";
            this.HighDetail.UseVisualStyleBackColor = true;
            this.HighDetail.Click += new System.EventHandler(this.HighDetail_Click);
            // 
            // LowDetail
            // 
            this.LowDetail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowDetail.Location = new System.Drawing.Point(6, 48);
            this.LowDetail.Name = "LowDetail";
            this.LowDetail.Size = new System.Drawing.Size(75, 23);
            this.LowDetail.TabIndex = 1;
            this.LowDetail.Text = "Low";
            this.LowDetail.UseVisualStyleBackColor = true;
            this.LowDetail.Click += new System.EventHandler(this.LowDetail_Click);
            // 
            // UltraLowDetail
            // 
            this.UltraLowDetail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltraLowDetail.Location = new System.Drawing.Point(6, 78);
            this.UltraLowDetail.Name = "UltraLowDetail";
            this.UltraLowDetail.Size = new System.Drawing.Size(75, 23);
            this.UltraLowDetail.TabIndex = 2;
            this.UltraLowDetail.Text = "Ultra low";
            this.UltraLowDetail.UseVisualStyleBackColor = true;
            this.UltraLowDetail.Click += new System.EventHandler(this.UltraLowDetail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HighDetail);
            this.groupBox1.Controls.Add(this.UltraLowDetail);
            this.groupBox1.Controls.Add(this.LowDetail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Savegame
            // 
            this.Savegame.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savegame.Location = new System.Drawing.Point(106, 20);
            this.Savegame.Name = "Savegame";
            this.Savegame.Size = new System.Drawing.Size(86, 103);
            this.Savegame.TabIndex = 4;
            this.Savegame.Text = "Delete savegame";
            this.Savegame.UseVisualStyleBackColor = true;
            this.Savegame.Click += new System.EventHandler(this.Savegame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 139);
            this.Controls.Add(this.Savegame);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "smb_launcher";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighDetail;
        private System.Windows.Forms.Button LowDetail;
        private System.Windows.Forms.Button UltraLowDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Savegame;
    }
}

