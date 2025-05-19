namespace FinalProject
{
    partial class MainLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.pnlTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.picStudent);
            this.pnlLogin.Controls.Add(this.btnStudent);
            this.pnlLogin.Controls.Add(this.pnlTeacher);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(650, 353);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // picStudent
            // 
            this.picStudent.BackColor = System.Drawing.Color.Transparent;
            this.picStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStudent.BackgroundImage")));
            this.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStudent.Location = new System.Drawing.Point(93, 32);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(146, 234);
            this.picStudent.TabIndex = 3;
            this.picStudent.TabStop = false;
            this.picStudent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudent.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStudent.Location = new System.Drawing.Point(93, 285);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(148, 35);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.Controls.Add(this.picTeacher);
            this.pnlTeacher.Controls.Add(this.btnTeacher);
            this.pnlTeacher.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTeacher.Location = new System.Drawing.Point(340, 0);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(310, 353);
            this.pnlTeacher.TabIndex = 0;
            this.pnlTeacher.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTeacher_Paint);
            // 
            // picTeacher
            // 
            this.picTeacher.BackColor = System.Drawing.Color.Transparent;
            this.picTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTeacher.BackgroundImage")));
            this.picTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTeacher.Location = new System.Drawing.Point(31, 18);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(219, 261);
            this.picTeacher.TabIndex = 4;
            this.picTeacher.TabStop = false;
            this.picTeacher.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeacher.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Location = new System.Drawing.Point(75, 285);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(148, 35);
            this.btnTeacher.TabIndex = 1;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLogin);
            this.Name = "MainLogin";
            this.Size = new System.Drawing.Size(650, 353);
            this.Load += new System.EventHandler(this.MainLogin_Load);
            this.Click += new System.EventHandler(this.MainLogin_Click);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.pnlTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel pnlTeacher;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.Button btnTeacher;
    }
}
