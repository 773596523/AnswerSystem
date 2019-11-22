using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using AnswerSystemWPF.Body;
using AnswerSystemWPF.Command;
using AnswerSystemWPF.IBLL;
using NPOI.SS.Formula.Functions;

namespace AnswerSystemWPF.ViewModel
{
    public class LoginWindowModel : ViewModelBase, IValidationExceptionHandler
    {
        public LoginWindowModel()
        {

        }

        private bool _isValid = false;
        public bool IsValid
        {
            get
            {
                if (!_isValid)
                {
                    _isValid = LoginStudent.IsValid;
                }
                return _isValid;
            }
            set
            {
                if (value == _isValid)
                    return;

                _isValid = value;
                OnPropertyChanged(nameof(IsValid));
            }
        }

        private Student _loginStudent = new Student();

        public Student LoginStudent
        {
            get => _loginStudent;
            set
            {
                LoginStudent = value;
                OnPropertyChanged(nameof(LoginStudent));
            }
        }

        private void Login(object sender)
        {
            if (!LoginStudent.IsValid)
            {
                MessageBox.Show("请补全相关信息");
                return;
            }

            AppSetting.Student = this.LoginStudent;

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Window win = sender as Window;
            win.Close();
        }


        public ICommand btnLogin => new DelegateCommand(Login);



    }
}
