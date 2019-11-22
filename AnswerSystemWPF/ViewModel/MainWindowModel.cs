using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnswerSystemWPF.Body;

namespace AnswerSystemWPF.ViewModel
{
    public class MainWindowModel : ViewModelBase
    {
        private Student loginStudent = AppSetting.Student;
        public Student LoginStudent
        {
            get => loginStudent;
            set
            {
                loginStudent = value;
                OnPropertyChanged(nameof(LoginStudent));
            }
        }

    }
}
