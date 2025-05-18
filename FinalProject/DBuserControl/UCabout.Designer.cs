namespace FinalProject.DBuserControl
{
    partial class UCabout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCabout));
            this.flpAbout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.flpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpAbout
            // 
            this.flpAbout.AutoScroll = true;
            this.flpAbout.BackColor = System.Drawing.Color.Transparent;
            this.flpAbout.Controls.Add(this.lblAbout);
            this.flpAbout.Location = new System.Drawing.Point(65, 24);
            this.flpAbout.Name = "flpAbout";
            this.flpAbout.Size = new System.Drawing.Size(761, 306);
            this.flpAbout.TabIndex = 0;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(3, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(726, 1140);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // UCabout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpAbout);
            this.Name = "UCabout";
            this.Size = new System.Drawing.Size(884, 351);
            this.Load += new System.EventHandler(this.UCabout_Load);
            this.flpAbout.ResumeLayout(false);
            this.flpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAbout;
        private System.Windows.Forms.Label lblAbout;
    }
}
