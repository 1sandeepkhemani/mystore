namespace mystore
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.USERNAMEtextBox = new System.Windows.Forms.TextBox();
            this.PASSWORDtextBox = new System.Windows.Forms.TextBox();
            this.SHOWPASSWORDcheckBox = new System.Windows.Forms.CheckBox();
            this.LOGINbutton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // USERNAMEtextBox
            // 
            this.USERNAMEtextBox.Location = new System.Drawing.Point(475, 202);
            this.USERNAMEtextBox.Name = "USERNAMEtextBox";
            this.USERNAMEtextBox.Size = new System.Drawing.Size(219, 22);
            this.USERNAMEtextBox.TabIndex = 6;
            // 
            // PASSWORDtextBox
            // 
            this.PASSWORDtextBox.Location = new System.Drawing.Point(475, 252);
            this.PASSWORDtextBox.Name = "PASSWORDtextBox";
            this.PASSWORDtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PASSWORDtextBox.Size = new System.Drawing.Size(219, 22);
            this.PASSWORDtextBox.TabIndex = 7;
            this.PASSWORDtextBox.UseSystemPasswordChar = true;
            // 
            // SHOWPASSWORDcheckBox
            // 
            this.SHOWPASSWORDcheckBox.AutoSize = true;
            this.SHOWPASSWORDcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOWPASSWORDcheckBox.Location = new System.Drawing.Point(475, 291);
            this.SHOWPASSWORDcheckBox.Name = "SHOWPASSWORDcheckBox";
            this.SHOWPASSWORDcheckBox.Size = new System.Drawing.Size(188, 29);
            this.SHOWPASSWORDcheckBox.TabIndex = 8;
            this.SHOWPASSWORDcheckBox.Text = "Show Password";
            this.SHOWPASSWORDcheckBox.UseVisualStyleBackColor = true;
            this.SHOWPASSWORDcheckBox.CheckedChanged += new System.EventHandler(this.SHOWPASSWORDcheckBox_CheckedChanged);
            // 
            // LOGINbutton
            // 
            this.LOGINbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGINbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGINbutton.Location = new System.Drawing.Point(400, 350);
            this.LOGINbutton.Name = "LOGINbutton";
            this.LOGINbutton.Size = new System.Drawing.Size(263, 47);
            this.LOGINbutton.TabIndex = 9;
            this.LOGINbutton.Text = "LOGIN";
            this.LOGINbutton.UseVisualStyleBackColor = true;
            this.LOGINbutton.Click += new System.EventHandler(this.LOGINbutton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(360, 429);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(304, 22);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New Registered Yet ? Click Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 533);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LOGINbutton);
            this.Controls.Add(this.SHOWPASSWORDcheckBox);
            this.Controls.Add(this.PASSWORDtextBox);
            this.Controls.Add(this.USERNAMEtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox USERNAMEtextBox;
        private System.Windows.Forms.TextBox PASSWORDtextBox;
        private System.Windows.Forms.CheckBox SHOWPASSWORDcheckBox;
        private System.Windows.Forms.Button LOGINbutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}