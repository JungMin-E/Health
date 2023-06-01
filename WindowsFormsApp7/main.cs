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
    public partial class main : Form
    {

        public class User
        {
            public  string Username { get; set; }
            public  string Password { get; set; }
        }

        private List<User> users;
        private string filePath = "users.txt";

        public main()
        {
            InitializeComponent();
            users = LoadUsers();
        }

        private List<User> LoadUsers()
        {
            List<User> loadedUsers = new List<User>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 2)
                    {
                        string username = parts[0];
                        string password = parts[1];
                        loadedUsers.Add(new User { Username = username, Password = password });
                    }
                }
            }

            return loadedUsers;
        }

        private void SaveUsers(List<User> usersToSave)
        {
            List<string> lines = new List<string>();

            foreach (User user in usersToSave)
            {
                string line = user.Username + ";" + user.Password;
                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 로그인 버튼 클릭 이벤트 처리
            string username = IdText.Text;
            string password = PwText.Text;
            string loggedInUserId = ValidateUser(username, password);
            if (loggedInUserId != null)
            {
                MessageBox.Show("로그인 성공");
                MenuForm menuForm = new MenuForm();
                menuForm.Username = username;
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        public string ValidateUser(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return username; // 로그인 성공
                }
            }

            return null; // 로그인 실패
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            DialogResult result = signupForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string username = signupForm.Username;
                string password = signupForm.Password;

                bool isDuplicate = users.Any(user => user.Username == username);
                if (isDuplicate)
                {
                    MessageBox.Show("이미 존재하는 아이디입니다. 다른 아이디를 입력해주세요.");
                    return;
                }

                User newUser = new User { Username = username, Password = password };
                users.Add(newUser);

                SaveUsers(users); // 새로운 회원 정보를 텍스트 파일에 저장

                MessageBox.Show("회원가입이 완료되었습니다.");
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
