namespace FinalProject.DBuserControl
{
    partial class UChome
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
            this.lblContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.Red;
            this.lblContent.Location = new System.Drawing.Point(78, 90);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(721, 148);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "the introductory page of a website,\r\ntypically serving as a table of contents for" +
    " the site.\r\nthe introductory page of a website,\r\ntypically serving as a table of" +
    " contents for the site.";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContent.Click += new System.EventHandler(this.label1_Click);
            // 
            // UChome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblContent);
            this.Name = "UChome";
            this.Size = new System.Drawing.Size(884, 351);
            this.Load += new System.EventHandler(this.UChome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
    }
}
