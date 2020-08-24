namespace WindowsFormsApp1
{
    partial class TEST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEST));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmark = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(128, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 363);
            this.panel1.TabIndex = 0;
            // 
            // lblmark
            // 
            this.lblmark.AutoSize = true;
            this.lblmark.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblmark.Location = new System.Drawing.Point(38, 69);
            this.lblmark.Name = "lblmark";
            this.lblmark.Size = new System.Drawing.Size(31, 19);
            this.lblmark.TabIndex = 1;
            this.lblmark.Text = "00";
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.next.Location = new System.Drawing.Point(352, 496);
            this.next.Name = "next";
            this.next.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.next.Size = new System.Drawing.Size(75, 35);
            this.next.TabIndex = 2;
            this.next.Text = "הבא";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 553);
            this.Controls.Add(this.next);
            this.Controls.Add(this.lblmark);
            this.Controls.Add(this.panel1);
            this.Name = "TEST";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TEST_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmark;
        private System.Windows.Forms.Button next;
    }
}