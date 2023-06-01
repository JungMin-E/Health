namespace WindowsFormsApp7
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdText = new System.Windows.Forms.TextBox();
            this.PwText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(348, 166);
            this.IdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(99, 21);
            this.IdText.TabIndex = 0;
            this.IdText.Text = "아이디";
            // 
            // PwText
            // 
            this.PwText.Location = new System.Drawing.Point(348, 206);
            this.PwText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PwText.Name = "PwText";
            this.PwText.PasswordChar = '*';
            this.PwText.Size = new System.Drawing.Size(99, 21);
            this.PwText.TabIndex = 1;
            this.PwText.Text = "비밀번호";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(468, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(166, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 64);
            this.label3.TabIndex = 5;
            this.label3.Text = "light weight";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.SkyBlue;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.SystemColors.Control;
            this.signupButton.Location = new System.Drawing.Point(468, 202);
            this.signupButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(72, 22);
            this.signupButton.TabIndex = 6;
            this.signupButton.Text = "회원가입";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp7.Properties.Resources.스크린샷_2023_05_31_오후_10_35_22;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 501);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 502);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PwText);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox PwText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

