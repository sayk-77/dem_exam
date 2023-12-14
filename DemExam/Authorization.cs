using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DemExam
{
  public partial class Authorization : Form
  {
    private DataBase _db;
    private int _loginAttempts;
    public Authorization()
    {
      InitializeComponent();
      _db = new DataBase();
      _loginAttempts = 0;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
      string loginUser = UserLogin.Text;
      string passwordUser = UserPassword.Text;

      if (_loginAttempts >= 1)
      {
        if (!OpenCaptcha())
        {
          btnLogin.Enabled = false;
          await Task.Delay(10 * 1000);
          btnLogin.Enabled = true;
          return;
        }
      }
      
      if (loginUser.Trim() == "" || passwordUser.Trim() == "") MessageBox.Show("Пользователь не найден");
      
      _db.OpenConnection();
      
      string queryForAuthorization = $"select * from user where UserLogin = @loginUser";
      MySqlCommand command = new MySqlCommand(queryForAuthorization, _db.GetConnection());
      command.Parameters.AddWithValue("@loginUser", loginUser);
      MySqlDataReader reader = command.ExecuteReader();

      if (!reader.Read())
      {
        MessageBox.Show("Пользователь не найден");
      }
      else
      {
        string password = reader["UserPassword"].ToString();
        string nameUser = $"{reader["UserName"].ToString()} {reader["UserPatronymic"]} {reader["UserSurname"]}";
        if (password == passwordUser)
        {
          MessageBox.Show("Успешная авторизация");
          Hide();
          AdminWindow aw = new AdminWindow(nameUser);
          aw.ShowDialog();
        }
        else
        {
          MessageBox.Show("Не верный пароль");
          _loginAttempts++;
        }
        Show();
      }
      
      reader.Close();
      _db.CloseConnection();
    }

    private bool OpenCaptcha()
    {
      Captcha formCaptcha = new Captcha();
      formCaptcha.ShowDialog();

      return formCaptcha.GetCaptchaAccess();
    }
  }
}
