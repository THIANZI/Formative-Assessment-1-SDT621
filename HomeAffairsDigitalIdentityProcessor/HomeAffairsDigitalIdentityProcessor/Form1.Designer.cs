namespace HomeAffairsDigitalIdentityProcessor
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
            lblTitle = new Label();
            lblName = new Label();
            lblID = new Label();
            lblCitizen = new Label();
            cmbCitizen = new ComboBox();
            txtName = new TextBox();
            txtID = new TextBox();
            btnValidate = new Button();
            btnGenerate = new Button();
            txtSummary = new GroupBox();
            lblResult = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AllowDrop = true;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SeaGreen;
            lblTitle.Location = new Point(381, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(385, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(432, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(161, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your Name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(463, 139);
            lblID.Name = "lblID";
            lblID.Size = new Size(130, 25);
            lblID.TabIndex = 2;
            lblID.Text = "Enter your ID:";
            // 
            // lblCitizen
            // 
            lblCitizen.AutoSize = true;
            lblCitizen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCitizen.Location = new Point(407, 189);
            lblCitizen.Name = "lblCitizen";
            lblCitizen.Size = new Size(186, 25);
            lblCitizen.TabIndex = 3;
            lblCitizen.Text = "Choose your Citizen:";
            // 
            // cmbCitizen
            // 
            cmbCitizen.DisplayMember = "South African";
            cmbCitizen.FormattingEnabled = true;
            cmbCitizen.Items.AddRange(new object[] { "South African", "Other" });
            cmbCitizen.Location = new Point(599, 186);
            cmbCitizen.Name = "cmbCitizen";
            cmbCitizen.Size = new Size(189, 28);
            cmbCitizen.TabIndex = 4;
            cmbCitizen.SelectedIndexChanged += cmbCitizen_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(599, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 27);
            txtName.TabIndex = 5;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(599, 137);
            txtID.Name = "txtID";
            txtID.Size = new Size(189, 27);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.SeaGreen;
            btnValidate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.Location = new Point(502, 239);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(153, 29);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.SeaGreen;
            btnGenerate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(502, 515);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(153, 29);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(497, 330);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(291, 158);
            txtSummary.TabIndex = 9;
            txtSummary.TabStop = false;
            txtSummary.Text = "groupBox1";
            txtSummary.Enter += txtSummary_Enter;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(502, 294);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 10;
            lblResult.Text = "label5";
            lblResult.Click += lblResult_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.SizeAll;
            pictureBox1.Image = Properties.Resources.Screenshot_2026_04_28_102956;
            pictureBox1.Location = new Point(53, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 160, 121);
            ClientSize = new Size(800, 585);
            Controls.Add(pictureBox1);
            Controls.Add(lblResult);
            Controls.Add(txtSummary);
            Controls.Add(btnGenerate);
            Controls.Add(btnValidate);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(cmbCitizen);
            Controls.Add(lblCitizen);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblID;
        private Label lblCitizen;
        private ComboBox cmbCitizen;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnValidate;
        private Button btnGenerate;
        private GroupBox txtSummary;
        private Label lblResult;
        private PictureBox pictureBox1;
    }
}
