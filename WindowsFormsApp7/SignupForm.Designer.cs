namespace WindowsFormsApp7
{
    partial class SignupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newID = new System.Windows.Forms.TextBox();
            this.newPW = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "회원가입";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.SkyBlue;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(198, 260);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(66, 18);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "확인";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SkyBlue;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(198, 287);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 18);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newID
            // 
            this.newID.BackColor = System.Drawing.SystemColors.Control;
            this.newID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newID.Location = new System.Drawing.Point(136, 194);
            this.newID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newID.Name = "newID";
            this.newID.Size = new System.Drawing.Size(188, 14);
            this.newID.TabIndex = 5;
            this.newID.TextChanged += new System.EventHandler(this.newID_TextChanged);
            // 
            // newPW
            // 
            this.newPW.BackColor = System.Drawing.SystemColors.Control;
            this.newPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPW.Location = new System.Drawing.Point(137, 233);
            this.newPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPW.Name = "newPW";
            this.newPW.PasswordChar = '*';
            this.newPW.Size = new System.Drawing.Size(189, 14);
            this.newPW.TabIndex = 6;
            this.newPW.TextChanged += new System.EventHandler(this.newPW_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(136, 211);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(-46, -18);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 1);
            this.panel5.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 1);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(-1, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 1);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(-1, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(136, 249);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(188, 1);
            this.panel6.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(134, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(134, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.pngtree_purple_blue_gradient_background_image_501302;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 165);
            this.panel7.TabIndex = 11;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp7.Properties.Resources.png_clipart_padlock_key_padlock_technic_share_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(153, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 321);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newPW);
            this.Controls.Add(this.newID);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox newID;
        private System.Windows.Forms.TextBox newPW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}