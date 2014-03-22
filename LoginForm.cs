using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfoProxy.Data;
using InfoProxy.UserData;

namespace Client
{
    public partial class LoginForm : Form
    {
        private Repository _repository;
        private UserData _user;

        public LoginForm()
        {
            InitializeComponent();
            _repository = new Repository();
            this.textPwd.PasswordChar = '*';
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _user = new UserData()
            {
                Key = textKey.Text,
                Pwd = textPwd.Text,
                Sec = textSecret.Text,
                Usr = textUser.Text
            };

            _repository.SaveUser(_user, GetPwd());

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private UserData LoadUser()
        {
            return _repository.GetUser(GetPwd());
        }

        public UserData UserData
        {
            get
            {
                return _user;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _user = _repository.GetUser(GetPwd());
            if (_user != null)
            {
                textKey.Text = _user.Key;
                textSecret.Text = _user.Sec;
                textUser.Text = _user.Usr;
                textPwd.Text = "**************";
            }
        }

        private string GetPwd()
        {
            var pwd = System.Environment.MachineName + "_" + System.Environment.UserName;
            return pwd;
        }
    }
}
