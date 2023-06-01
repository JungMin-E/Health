using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;    
namespace WindowsFormsApp7
{
    public partial class MenuForm : Form
    {
        private string menuUsername;

        public string Username
        {
            get { return menuUsername; }
            set { menuUsername = value; }
        }

        private int previousSelectedIndex1 = -1;
        private int previousSelectedIndex2 = -1;
        private int previousSelectedIndex3 = -1;
        private int previousSelectedIndex4 = -1;
        private int previousSelectedIndex5 = -1;
        private int previousSelectedIndex6 = -1;
        private int previousSelectedIndex7 = -1;
        private string selectedmonListItem;
        private string selectedtueListItem;
        private string selectedwedListItem;
        private string selectedthuListItem;
        private string selectedfriListItem;
        private string selectedsatListItem;
        private string selectedsunListItem;
        private Dictionary<string, ListBox> listBoxes;
        private Dictionary<string, List<string>> exerciseDictionary;
        private List<string> selectedExercises;
        public MenuForm()
        {
            InitializeComponent();
            
            exerciseDictionary = new Dictionary<string, List<string>>
            {
                { "월요일", new List<string>() },
                { "화요일", new List<string>() },
                { "수요일", new List<string>() },
                { "목요일", new List<string>() },
                { "금요일", new List<string>() },
                { "토요일", new List<string>() },
                { "일요일", new List<string>() }
            };
            selectedExercises = new List<string>();
            dayComboBox.Items.AddRange(exerciseDictionary.Keys.ToArray());
        }
        private void InitializeListBoxes()
        {
            listBoxes = new Dictionary<string, ListBox>
            {
                { "월요일", monListBox },
                { "화요일", tueListBox },
                { "수요일", wedListBox },
                { "목요일", thuListBox },
                { "금요일", friListBox },
                { "토요일", satListBox },
                { "일요일", sunListBox },
            };
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            exerciseComboBox.Items.Add("Chest");
            exerciseComboBox.Items.Add("Back");
            exerciseComboBox.Items.Add("Leg");
            exerciseComboBox.Items.Add("유산소");
            exerciseComboBox.Items.Add("Shoulder");
            exerciseComboBox.Items.Add("Arms");
            startComboBox.Items.Add("월요일");
            startComboBox.Items.Add("화요일");
            startComboBox.Items.Add("수요일");
            startComboBox.Items.Add("목요일");
            startComboBox.Items.Add("금요일");
            startComboBox.Items.Add("토요일");
            startComboBox.Items.Add("일요일");
            string username = menuUsername; // 다른 폼에서 username을 받아온다고 가정합니다.

            LoadUserListBoxDataFromFile(monListBox, username, "mon");
            LoadUserListBoxDataFromFile(tueListBox, username, "tue");
            LoadUserListBoxDataFromFile(wedListBox, username, "wed");
            LoadUserListBoxDataFromFile(thuListBox, username, "thu");
            LoadUserListBoxDataFromFile(friListBox, username, "fri");
            LoadUserListBoxDataFromFile(satListBox, username, "sat");
            LoadUserListBoxDataFromFile(sunListBox, username, "sun");


        }



        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exerciseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedExercise = exerciseComboBox.SelectedItem.ToString();
            if (selectedExercise == "Chest")
            {
                selectExerciseCheckedListBox.Items.Clear();
                selectExerciseCheckedListBox.Items.Add("벤치프레스");
                selectExerciseCheckedListBox.Items.Add("인클라인벤치프레스");
                selectExerciseCheckedListBox.Items.Add("딥스");
                selectExerciseCheckedListBox.Items.Add("푸시업");
                selectExerciseCheckedListBox.Items.Add("체스트 플라이");
                selectExerciseCheckedListBox.Items.Add("체스트 프레스 머신");
            }
            else if (selectedExercise == "Back")
            {
                selectExerciseCheckedListBox.Items.Clear();
                selectExerciseCheckedListBox.Items.Add("렛풀다운");
                selectExerciseCheckedListBox.Items.Add("턱걸이");
                selectExerciseCheckedListBox.Items.Add("T바로우");
                selectExerciseCheckedListBox.Items.Add("바벨로우");
                selectExerciseCheckedListBox.Items.Add("데드리프트");
                selectExerciseCheckedListBox.Items.Add("원 암 덤벨로우");
            }
            else if (selectedExercise == "Arms")
            {
                selectExerciseCheckedListBox.Items.Clear();
                selectExerciseCheckedListBox.Items.Add("Arm Curl");
                selectExerciseCheckedListBox.Items.Add("Hammer Curl");
                selectExerciseCheckedListBox.Items.Add("Babel Curl");
                selectExerciseCheckedListBox.Items.Add("Wrist Curl");

            }
            else if (selectedExercise == "Shoulder")
            {
                selectExerciseCheckedListBox.Items.Clear();
                selectExerciseCheckedListBox.Items.Add("Side Lateral Raise");
                selectExerciseCheckedListBox.Items.Add("Shoulder Press");
                selectExerciseCheckedListBox.Items.Add("Bentover Lateral Raise");
                selectExerciseCheckedListBox.Items.Add("Reverse Peck Deck Fly");
                selectExerciseCheckedListBox.Items.Add("Military Press");

            }
            else if (selectedExercise == "Leg")
            {
                selectExerciseCheckedListBox.Items.Clear();
                selectExerciseCheckedListBox.Items.Add("스쿼트");
                selectExerciseCheckedListBox.Items.Add("레그프레스");
                selectExerciseCheckedListBox.Items.Add("레그 익스텐션");
                selectExerciseCheckedListBox.Items.Add("레그 컬");
            }
            else if (selectedExercise == "유산소")
            {
                selectExerciseCheckedListBox.Items.Clear();
                selectExerciseCheckedListBox.Items.Add("런닝머신");
                selectExerciseCheckedListBox.Items.Add("싸이클");
                selectExerciseCheckedListBox.Items.Add("스텝밀머신(천국의 계단)");

            }
        }

        private void nextComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selectExerciseCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void exerciseAddButton_Click(object sender, EventArgs e)
        {
            string selectedDay = dayComboBox.SelectedItem?.ToString();
            if (selectedDay == "월요일")
            {
                foreach (object item in selectExerciseCheckedListBox.CheckedItems)
                {
                    monListBox.Items.Add(item.ToString());
                }
                if(!string.IsNullOrWhiteSpace(myExerciseTextBox.Text))
                    monListBox.Items.Add(myExerciseTextBox.Text);
            }if (selectedDay == "화요일")
            {
                foreach (object item in selectExerciseCheckedListBox.CheckedItems)
                {
                    tueListBox.Items.Add(item.ToString());
                }
                if (!string.IsNullOrWhiteSpace(myExerciseTextBox.Text))
                    tueListBox.Items.Add(myExerciseTextBox.Text);
            }
            if (selectedDay == "수요일")
            {
                foreach (object item in selectExerciseCheckedListBox.CheckedItems)
                {
                    wedListBox.Items.Add(item.ToString());
                }
                if (!string.IsNullOrWhiteSpace(myExerciseTextBox.Text))
                    wedListBox.Items.Add(myExerciseTextBox.Text);
            }
            if (selectedDay == "목요일")
            {
                foreach (object item in selectExerciseCheckedListBox.CheckedItems)
                {
                    thuListBox.Items.Add(item.ToString());
                }
                if (!string.IsNullOrWhiteSpace(myExerciseTextBox.Text))
                    thuListBox.Items.Add(myExerciseTextBox.Text);
            }
            if (selectedDay == "금요일")
            {
                foreach (object item in selectExerciseCheckedListBox.CheckedItems)
                {
                    friListBox.Items.Add(item.ToString());
                }
                if (!string.IsNullOrWhiteSpace(myExerciseTextBox.Text))
                    friListBox.Items.Add(myExerciseTextBox.Text);
            }
            if (selectedDay == "토요일")
            {
                foreach (object item in selectExerciseCheckedListBox.CheckedItems)
                {
                    satListBox.Items.Add(item.ToString());
                }
                if (!string.IsNullOrWhiteSpace(myExerciseTextBox.Text))
                    satListBox.Items.Add(myExerciseTextBox.Text);
            }
            if (selectedDay == "일요일")
            {
                foreach (object item in selectExerciseCheckedListBox.CheckedItems)
                {
                    sunListBox.Items.Add(item.ToString());
                }
                if (!string.IsNullOrWhiteSpace(myExerciseTextBox.Text))
                    sunListBox.Items.Add(myExerciseTextBox.Text);
            }
            
        }

        private void exerciseDeleteButton_Click(object sender, EventArgs e)
        {
            if (monListBox.SelectedIndex != -1)
            {
                monListBox.Items.RemoveAt(monListBox.SelectedIndex);                
            }

            if (tueListBox.SelectedIndex != -1)
            {
                tueListBox.Items.RemoveAt(tueListBox.SelectedIndex);                
            }

            if (wedListBox.SelectedIndex != -1)
            {
                wedListBox.Items.RemoveAt(wedListBox.SelectedIndex);
            }

            if (thuListBox.SelectedIndex != -1)
            {
                thuListBox.Items.RemoveAt(thuListBox.SelectedIndex);
            }

            if (friListBox.SelectedIndex != -1)
            {
                friListBox.Items.RemoveAt(friListBox.SelectedIndex);
            }

            if (satListBox.SelectedIndex != -1)
            {
                satListBox.Items.RemoveAt(satListBox.SelectedIndex);
            }

            if (sunListBox.SelectedIndex != -1)
            {
                sunListBox.Items.RemoveAt(sunListBox.SelectedIndex);
            }

        }

        private void monListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = monListBox.SelectedIndex;
            if (selectedIndex == previousSelectedIndex1)
            {
                monListBox.ClearSelected(); 
                previousSelectedIndex1 = -1; 
            }
            else
            {
                previousSelectedIndex1 = selectedIndex; 
            }
            selectedmonListItem = monListBox.SelectedItem?.ToString();
        }

        private void tueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tueListBox.SelectedIndex;
            if (selectedIndex == previousSelectedIndex2)
            {
                tueListBox.ClearSelected();
                previousSelectedIndex2 = -1;
            }
            else
            {
                previousSelectedIndex2 = selectedIndex;
            }
            selectedtueListItem = tueListBox.SelectedItem?.ToString();

        }
        private void wedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = wedListBox.SelectedIndex;
            if (selectedIndex == previousSelectedIndex3)
            {
                wedListBox.ClearSelected();
                previousSelectedIndex3 = -1;
            }
            else
            {
                previousSelectedIndex3 = selectedIndex;
            }
            selectedwedListItem = wedListBox.SelectedItem?.ToString();

        }
        private void thuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = thuListBox.SelectedIndex;
            if (selectedIndex == previousSelectedIndex4)
            {
                thuListBox.ClearSelected();
                previousSelectedIndex4 = -1;
            }
            else
            {
                previousSelectedIndex4 = selectedIndex;
            }
            selectedthuListItem = thuListBox.SelectedItem?.ToString();

        }

        private void friListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = friListBox.SelectedIndex;
            if (selectedIndex == previousSelectedIndex5)
            {
                friListBox.ClearSelected();
                previousSelectedIndex5 = -1;
            }
            else
            {
                previousSelectedIndex5 = selectedIndex;
            }
            selectedfriListItem = friListBox.SelectedItem?.ToString();

        }

        private void satListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = satListBox.SelectedIndex;
            if (selectedIndex == previousSelectedIndex6)
            {
                satListBox.ClearSelected();
                previousSelectedIndex6 = -1;
            }
            else
            {
                previousSelectedIndex6 = selectedIndex;
            }
            selectedsatListItem = satListBox.SelectedItem?.ToString();

        }

        private void sunListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = sunListBox.SelectedIndex;
            if (selectedIndex == previousSelectedIndex7)
            {
                sunListBox.ClearSelected();
                previousSelectedIndex7 = -1;
            }
            else
            {
                previousSelectedIndex7 = selectedIndex;
            }
            selectedsunListItem = sunListBox.SelectedItem?.ToString();
        }

        private void SaveListBoxDataToFile(ListBox listBox, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (string item in listBox.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }
        private string GetFilePath(string username, string day)
        {
            return $"{username}_{day}.txt";
        }
        private void LoadUserListBoxDataFromFile(ListBox listBox, string username, string day)
        {
            string fileName = GetFilePath(username, day);
            listBox.Items.Clear();
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);
                    }
                }
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            string selectedDay = startComboBox.SelectedItem?.ToString();
            if (selectedDay == null)
            {
                MessageBox.Show("요일을 선택해주세요");
                return;
            }
            List<string> listBoxData = new List<string>();

            // 선택된 요일에 해당하는 리스트박스의 정보를 가져옴
            switch (selectedDay)
            {
                case "월요일":
                    listBoxData.AddRange(monListBox.Items.Cast<string>());
                    break;
                case "화요일":
                    listBoxData.AddRange(tueListBox.Items.Cast<string>());
                    break;
                case "수요일":
                    listBoxData.AddRange(wedListBox.Items.Cast<string>());
                    break;
                case "목요일":
                    listBoxData.AddRange(thuListBox.Items.Cast<string>());
                    break;
                case "금요일":
                    listBoxData.AddRange(friListBox.Items.Cast<string>());
                    break;
                case "토요일":
                    listBoxData.AddRange(satListBox.Items.Cast<string>());
                    break;
                case "일요일":
                    listBoxData.AddRange(sunListBox.Items.Cast<string>());
                    break;
            }
            if (listBoxData.Count == 0)
            {
                MessageBox.Show("항목을 추가해주세요.");
                return;
            }
            // ResultForm 인스턴스 생성
            SetForm setForm = new SetForm();

            // 데이터 전송
            setForm.LoadDataToDataGridView(listBoxData);

            // ResultForm을 보여줌
            setForm.ShowDialog();
        }




        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SaveUserListBoxDataToFile(ListBox listBox, string username, string day)
        {
            string fileName = GetFilePath(username, day);
            SaveListBoxDataToFile(listBox, fileName);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string username = menuUsername; // 다른 폼에서 username을 받아온다고 가정합니다.

            SaveUserListBoxDataToFile(monListBox, username, "mon");
            SaveUserListBoxDataToFile(tueListBox, username, "tue");
            SaveUserListBoxDataToFile(wedListBox, username, "wed");
            SaveUserListBoxDataToFile(thuListBox, username, "thu");
            SaveUserListBoxDataToFile(friListBox, username, "fri");
            SaveUserListBoxDataToFile(satListBox, username, "sat");
            SaveUserListBoxDataToFile(sunListBox, username, "sun");

            MessageBox.Show("데이터가 저장되었습니다.");
        }

        private void startComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dayComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void exerciseComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
