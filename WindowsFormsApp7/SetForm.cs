using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class SetForm : Form
    {
        private Timer timer;
        private int timeInSeconds;
        private int initialTimeInSeconds;
        private int pausedTimeInSeconds;

        public SetForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1초 간격으로 타이머 이벤트 발생
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeInSeconds--;
            if (timeInSeconds >= 0)
                UpdateTimeLabel();
            else
                StopTimer();
        }
        private void UpdateTimeLabel()
        {
            int minutes = timeInSeconds / 60;
            int seconds = timeInSeconds % 60;

            string timeString = $"{minutes:00}:{seconds:00}";
            timeLabel.Text = timeString;
        }

        private void setGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadDataToDataGridView(List<string> data)
        {
            // DataGridView에 데이터 로드
            dataGridView.Rows.Clear();
            foreach (string item in data)
            {
                dataGridView.Rows.Add(item);
            }
        }
        private void SetForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV 파일 (*.csv)|*.csv";
            saveFileDialog.Title = "CSV 파일로 저장";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                if (File.Exists(filePath))
                {
                    // 기존 파일이 있을 경우 파일에 추가 모드로 작성
                    using (var writer = new StreamWriter(filePath, true, Encoding.UTF8))
                    {
                        StringBuilder sb = new StringBuilder();

                        // 행 정보 작성
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (!row.IsNewRow) // 새로운 행은 저장하지 않음
                            {
                                IEnumerable<string> fields = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "");
                                sb.AppendLine(string.Join(",", fields));
                            }
                        }

                        // CSV 데이터 추가
                        writer.Write(sb.ToString());
                    }
                }
                else
                {
                    // 새로운 파일에 저장
                    SaveToCSV(dataGridView, filePath);
                }

                MessageBox.Show("CSV 파일이 저장되었습니다.");
            }
        }




        private void SaveToCSV(DataGridView dataGridView, string filePath)
        {
            // 파일을 UTF8 형식으로 저장
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();

                // 헤더 정보 작성
                IEnumerable<string> columnNames = dataGridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText);
                sb.AppendLine(string.Join(",", columnNames));

                // 행 정보 작성
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) // 새로운 행은 저장하지 않음
                    {
                        IEnumerable<string> fields = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "");
                        sb.AppendLine(string.Join(",", fields));
                    }
                }

                // CSV 파일 저장
                writer.Write(sb.ToString());
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(minutesTextBox.Text, out int minutes) && int.TryParse(secondsTextBox.Text, out int seconds))
            {
                if (!timer.Enabled) // 타이머가 정지된 상태라면
                {
                    // 시작 시간 설정
                    if (pausedTimeInSeconds == 0)
                        timeInSeconds = minutes * 60 + seconds; // 처음 시작 시간 설정
                    else
                        timeInSeconds = pausedTimeInSeconds; // 정지된 시간으로 시작

                    initialTimeInSeconds = timeInSeconds;
                    UpdateTimeLabel();
                    timer.Start();
                }
            }
            else
            {
                MessageBox.Show("유효한 시간을 입력하세요.");
            }
        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            int minutes;
            int seconds;

            if (timer.Enabled) // 타이머가 실행 중인 경우
            {
                if (!int.TryParse(minutesTextBox.Text, out minutes) || !int.TryParse(secondsTextBox.Text, out seconds))
                {
                    MessageBox.Show("유효한 시간을 입력하세요.");
                    return;
                }
            }
            else // 타이머가 정지된 상태인 경우
            {
                minutes = initialTimeInSeconds / 60;
                seconds = initialTimeInSeconds % 60;
            }

            int resetMinutes;
            int resetSeconds;
            if (!int.TryParse(minutesTextBox.Text, out resetMinutes) || !int.TryParse(secondsTextBox.Text, out resetSeconds))
            {
                MessageBox.Show("유효한 시간을 입력하세요.");
                return;
            }

            minutesTextBox.Text = resetMinutes.ToString();
            secondsTextBox.Text = resetSeconds.ToString();

            timeInSeconds = resetMinutes * 60 + resetSeconds;
            pausedTimeInSeconds = 0;
            timer.Stop();

            UpdateTimeLabel();
        }



        private void StopTimer()
        {
            if (timer.Enabled) // 타이머가 실행 중인 상태라면
            {
                timer.Stop();
                pausedTimeInSeconds = timeInSeconds; // 현재 시간 저장
            }
            else
            {
                pausedTimeInSeconds = 0; // 정지된 시간 초기화
            }
        }
    }
}
