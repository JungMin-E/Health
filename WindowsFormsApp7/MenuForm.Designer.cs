namespace WindowsFormsApp7
{
    partial class MenuForm
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
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.exerciseComboBox = new System.Windows.Forms.ComboBox();
            this.selectExerciseCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.exerciseAddButton = new System.Windows.Forms.Button();
            this.monListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tueListBox = new System.Windows.Forms.ListBox();
            this.wedListBox = new System.Windows.Forms.ListBox();
            this.thuListBox = new System.Windows.Forms.ListBox();
            this.friListBox = new System.Windows.Forms.ListBox();
            this.satListBox = new System.Windows.Forms.ListBox();
            this.sunListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exerciseDeleteButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.myExerciseTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(89, 140);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(121, 23);
            this.dayComboBox.TabIndex = 2;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.dayComboBox_SelectedIndexChanged);
            this.dayComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayComboBox_KeyPress);
            // 
            // exerciseComboBox
            // 
            this.exerciseComboBox.FormattingEnabled = true;
            this.exerciseComboBox.Location = new System.Drawing.Point(341, 140);
            this.exerciseComboBox.Name = "exerciseComboBox";
            this.exerciseComboBox.Size = new System.Drawing.Size(121, 23);
            this.exerciseComboBox.TabIndex = 3;
            this.exerciseComboBox.SelectedIndexChanged += new System.EventHandler(this.exerciseComboBox_SelectedIndexChanged);
            this.exerciseComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exerciseComboBox_KeyPress);
            // 
            // selectExerciseCheckedListBox
            // 
            this.selectExerciseCheckedListBox.FormattingEnabled = true;
            this.selectExerciseCheckedListBox.Location = new System.Drawing.Point(570, 140);
            this.selectExerciseCheckedListBox.Name = "selectExerciseCheckedListBox";
            this.selectExerciseCheckedListBox.Size = new System.Drawing.Size(241, 84);
            this.selectExerciseCheckedListBox.TabIndex = 5;
            this.selectExerciseCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.selectExerciseCheckedListBox_SelectedIndexChanged);
            // 
            // exerciseAddButton
            // 
            this.exerciseAddButton.Location = new System.Drawing.Point(886, 174);
            this.exerciseAddButton.Name = "exerciseAddButton";
            this.exerciseAddButton.Size = new System.Drawing.Size(75, 23);
            this.exerciseAddButton.TabIndex = 6;
            this.exerciseAddButton.Text = "추가";
            this.exerciseAddButton.UseVisualStyleBackColor = true;
            this.exerciseAddButton.Click += new System.EventHandler(this.exerciseAddButton_Click);
            // 
            // monListBox
            // 
            this.monListBox.FormattingEnabled = true;
            this.monListBox.ItemHeight = 15;
            this.monListBox.Location = new System.Drawing.Point(13, 333);
            this.monListBox.Name = "monListBox";
            this.monListBox.Size = new System.Drawing.Size(120, 94);
            this.monListBox.TabIndex = 7;
            this.monListBox.SelectedIndexChanged += new System.EventHandler(this.monListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "월요일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "금요일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "목요일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "수요일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "화요일";
            // 
            // tueListBox
            // 
            this.tueListBox.FormattingEnabled = true;
            this.tueListBox.ItemHeight = 15;
            this.tueListBox.Location = new System.Drawing.Point(168, 333);
            this.tueListBox.Name = "tueListBox";
            this.tueListBox.Size = new System.Drawing.Size(120, 94);
            this.tueListBox.TabIndex = 14;
            this.tueListBox.SelectedIndexChanged += new System.EventHandler(this.tueListBox_SelectedIndexChanged);
            // 
            // wedListBox
            // 
            this.wedListBox.FormattingEnabled = true;
            this.wedListBox.ItemHeight = 15;
            this.wedListBox.Location = new System.Drawing.Point(327, 333);
            this.wedListBox.Name = "wedListBox";
            this.wedListBox.Size = new System.Drawing.Size(120, 94);
            this.wedListBox.TabIndex = 15;
            this.wedListBox.SelectedIndexChanged += new System.EventHandler(this.wedListBox_SelectedIndexChanged);
            // 
            // thuListBox
            // 
            this.thuListBox.FormattingEnabled = true;
            this.thuListBox.ItemHeight = 15;
            this.thuListBox.Location = new System.Drawing.Point(481, 333);
            this.thuListBox.Name = "thuListBox";
            this.thuListBox.Size = new System.Drawing.Size(120, 94);
            this.thuListBox.TabIndex = 16;
            this.thuListBox.SelectedIndexChanged += new System.EventHandler(this.thuListBox_SelectedIndexChanged);
            // 
            // friListBox
            // 
            this.friListBox.FormattingEnabled = true;
            this.friListBox.ItemHeight = 15;
            this.friListBox.Location = new System.Drawing.Point(635, 333);
            this.friListBox.Name = "friListBox";
            this.friListBox.Size = new System.Drawing.Size(120, 94);
            this.friListBox.TabIndex = 17;
            this.friListBox.SelectedIndexChanged += new System.EventHandler(this.friListBox_SelectedIndexChanged);
            // 
            // satListBox
            // 
            this.satListBox.FormattingEnabled = true;
            this.satListBox.ItemHeight = 15;
            this.satListBox.Location = new System.Drawing.Point(785, 333);
            this.satListBox.Name = "satListBox";
            this.satListBox.Size = new System.Drawing.Size(120, 94);
            this.satListBox.TabIndex = 18;
            this.satListBox.SelectedIndexChanged += new System.EventHandler(this.satListBox_SelectedIndexChanged);
            // 
            // sunListBox
            // 
            this.sunListBox.FormattingEnabled = true;
            this.sunListBox.ItemHeight = 15;
            this.sunListBox.Location = new System.Drawing.Point(931, 333);
            this.sunListBox.Name = "sunListBox";
            this.sunListBox.Size = new System.Drawing.Size(120, 94);
            this.sunListBox.TabIndex = 19;
            this.sunListBox.SelectedIndexChanged += new System.EventHandler(this.sunListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(814, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "토요일";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(967, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "일요일";
            // 
            // exerciseDeleteButton
            // 
            this.exerciseDeleteButton.Location = new System.Drawing.Point(489, 471);
            this.exerciseDeleteButton.Name = "exerciseDeleteButton";
            this.exerciseDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.exerciseDeleteButton.TabIndex = 22;
            this.exerciseDeleteButton.Text = "삭제";
            this.exerciseDeleteButton.UseVisualStyleBackColor = true;
            this.exerciseDeleteButton.Click += new System.EventHandler(this.exerciseDeleteButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(931, 471);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "시작";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startComboBox
            // 
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(731, 472);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(121, 23);
            this.startComboBox.TabIndex = 24;
            this.startComboBox.SelectedIndexChanged += new System.EventHandler(this.startComboBox_SelectedIndexChanged);
            this.startComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startComboBox_KeyPress);
            // 
            // myExerciseTextBox
            // 
            this.myExerciseTextBox.Location = new System.Drawing.Point(570, 50);
            this.myExerciseTextBox.Name = "myExerciseTextBox";
            this.myExerciseTextBox.Size = new System.Drawing.Size(241, 25);
            this.myExerciseTextBox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "요일선택";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "부위 선택";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "세부종목선택";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "나만의 운동종목";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(489, 514);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 570);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.myExerciseTextBox);
            this.Controls.Add(this.startComboBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exerciseDeleteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sunListBox);
            this.Controls.Add(this.satListBox);
            this.Controls.Add(this.friListBox);
            this.Controls.Add(this.thuListBox);
            this.Controls.Add(this.wedListBox);
            this.Controls.Add(this.tueListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monListBox);
            this.Controls.Add(this.exerciseAddButton);
            this.Controls.Add(this.selectExerciseCheckedListBox);
            this.Controls.Add(this.exerciseComboBox);
            this.Controls.Add(this.dayComboBox);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.ComboBox exerciseComboBox;
        private System.Windows.Forms.CheckedListBox selectExerciseCheckedListBox;
        private System.Windows.Forms.Button exerciseAddButton;
        private System.Windows.Forms.ListBox monListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox tueListBox;
        private System.Windows.Forms.ListBox wedListBox;
        private System.Windows.Forms.ListBox thuListBox;
        private System.Windows.Forms.ListBox friListBox;
        private System.Windows.Forms.ListBox satListBox;
        private System.Windows.Forms.ListBox sunListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exerciseDeleteButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.TextBox myExerciseTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveButton;
    }
}