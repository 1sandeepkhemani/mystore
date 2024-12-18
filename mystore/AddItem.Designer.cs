namespace mystore
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TAXComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ITEMNAMETextBox = new System.Windows.Forms.TextBox();
            this.PRICETextBox = new System.Windows.Forms.TextBox();
            this.DISCOUNTTextBox = new System.Windows.Forms.TextBox();
            this.ADDCIRCLEBUTTON = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.81982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.18018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TAXComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ITEMNAMETextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PRICETextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DISCOUNTTextBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(136, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.99177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 395);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TAXComboBox
            // 
            this.TAXComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TAXComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAXComboBox.FormattingEnabled = true;
            this.TAXComboBox.Items.AddRange(new object[] {
            "0",
            "5",
            "12",
            "18",
            "24",
            "36"});
            this.TAXComboBox.Location = new System.Drawing.Point(224, 327);
            this.TAXComboBox.Name = "TAXComboBox";
            this.TAXComboBox.Size = new System.Drawing.Size(287, 37);
            this.TAXComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 99);
            this.label4.TabIndex = 2;
            this.label4.Text = "PRICE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 98);
            this.label7.TabIndex = 5;
            this.label7.Text = "TAX %";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 99);
            this.label5.TabIndex = 3;
            this.label5.Text = "DISCOUNT PER ITEM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 99);
            this.label2.TabIndex = 0;
            this.label2.Text = "ITEM NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ITEMNAMETextBox
            // 
            this.ITEMNAMETextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ITEMNAMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITEMNAMETextBox.Location = new System.Drawing.Point(224, 32);
            this.ITEMNAMETextBox.Name = "ITEMNAMETextBox";
            this.ITEMNAMETextBox.Size = new System.Drawing.Size(287, 34);
            this.ITEMNAMETextBox.TabIndex = 6;
            // 
            // PRICETextBox
            // 
            this.PRICETextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PRICETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICETextBox.Location = new System.Drawing.Point(224, 131);
            this.PRICETextBox.Name = "PRICETextBox";
            this.PRICETextBox.Size = new System.Drawing.Size(287, 34);
            this.PRICETextBox.TabIndex = 10;
            // 
            // DISCOUNTTextBox
            // 
            this.DISCOUNTTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DISCOUNTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISCOUNTTextBox.Location = new System.Drawing.Point(224, 230);
            this.DISCOUNTTextBox.Name = "DISCOUNTTextBox";
            this.DISCOUNTTextBox.Size = new System.Drawing.Size(287, 34);
            this.DISCOUNTTextBox.TabIndex = 11;
            // 
            // ADDCIRCLEBUTTON
            // 
            this.ADDCIRCLEBUTTON.Animated = true;
            this.ADDCIRCLEBUTTON.AnimationHoverSpeed = 0.07F;
            this.ADDCIRCLEBUTTON.AnimationSpeed = 0.03F;
            this.ADDCIRCLEBUTTON.BaseColor = System.Drawing.Color.Indigo;
            this.ADDCIRCLEBUTTON.BorderColor = System.Drawing.Color.Black;
            this.ADDCIRCLEBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDCIRCLEBUTTON.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ADDCIRCLEBUTTON.FocusedColor = System.Drawing.Color.Empty;
            this.ADDCIRCLEBUTTON.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDCIRCLEBUTTON.ForeColor = System.Drawing.Color.White;
            this.ADDCIRCLEBUTTON.Image = null;
            this.ADDCIRCLEBUTTON.ImageSize = new System.Drawing.Size(52, 52);
            this.ADDCIRCLEBUTTON.Location = new System.Drawing.Point(331, 590);
            this.ADDCIRCLEBUTTON.Name = "ADDCIRCLEBUTTON";
            this.ADDCIRCLEBUTTON.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ADDCIRCLEBUTTON.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ADDCIRCLEBUTTON.OnHoverForeColor = System.Drawing.Color.White;
            this.ADDCIRCLEBUTTON.OnHoverImage = null;
            this.ADDCIRCLEBUTTON.OnPressedColor = System.Drawing.Color.Black;
            this.ADDCIRCLEBUTTON.Size = new System.Drawing.Size(132, 107);
            this.ADDCIRCLEBUTTON.TabIndex = 14;
            this.ADDCIRCLEBUTTON.Text = "ADD";
            this.ADDCIRCLEBUTTON.Click += new System.EventHandler(this.ADDCIRCLEBUTTON_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 15;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = null;
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.Location = new System.Drawing.Point(8, 8);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.TabIndex = 16;
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton3.Image = global::mystore.Properties.Resources.go_back256_24856;
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton3.Location = new System.Drawing.Point(12, 32);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = null;
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(103, 105);
            this.gunaImageButton3.TabIndex = 17;
            this.gunaImageButton3.Click += new System.EventHandler(this.gunaImageButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mystore.Properties.Resources.Mystore;
            this.pictureBox1.Location = new System.Drawing.Point(136, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(788, 714);
            this.Controls.Add(this.gunaImageButton3);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ADDCIRCLEBUTTON);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox DISCOUNTTextBox;
        private System.Windows.Forms.TextBox PRICETextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ITEMNAMETextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TAXComboBox;
        private Guna.UI.WinForms.GunaCircleButton ADDCIRCLEBUTTON;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
    }
}