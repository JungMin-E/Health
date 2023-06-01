namespace WindowsFormsApp7
{
    partial class SetForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.종목 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.횟수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.무게 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.세트수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목,
            this.횟수,
            this.무게,
            this.세트수,
            this.Column1,
            this.Column2});
            this.dataGridView.Location = new System.Drawing.Point(120, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(855, 250);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // 종목
            // 
            this.종목.HeaderText = "종목";
            this.종목.MinimumWidth = 6;
            this.종목.Name = "종목";
            this.종목.Width = 125;
            // 
            // 횟수
            // 
            this.횟수.HeaderText = "횟수";
            this.횟수.MinimumWidth = 6;
            this.횟수.Name = "횟수";
            this.횟수.Width = 125;
            // 
            // 무게
            // 
            this.무게.HeaderText = "무게";
            this.무게.MinimumWidth = 6;
            this.무게.Name = "무게";
            this.무게.Width = 125;
            // 
            // 세트수
            // 
            this.세트수.HeaderText = "세트수";
            this.세트수.MinimumWidth = 6;
            this.세트수.Name = "세트수";
            this.세트수.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "성공 여부";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "날짜";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(999, 152);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("굴림", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(127, 280);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(799, 236);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "00:00";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1035, 454);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "시작";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1035, 493);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "정지";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1035, 531);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "리셋";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Location = new System.Drawing.Point(1035, 381);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(100, 25);
            this.minutesTextBox.TabIndex = 6;
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(1035, 412);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 25);
            this.secondsTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1007, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "분";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1007, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "초";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "SetForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목;
        private System.Windows.Forms.DataGridViewTextBoxColumn 횟수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 무게;
        private System.Windows.Forms.DataGridViewTextBoxColumn 세트수;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}