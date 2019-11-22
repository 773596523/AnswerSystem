using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnswerSystemWPF.Body;

namespace AnswerSystemWPF.View
{
    /// <summary>
    /// SelectSubjectView.xaml 的交互逻辑
    /// </summary>
    public partial class SelectSubjectView : Page
    {
        public SelectSubjectView()
        {
            InitializeComponent();
        }

        private void BtnNet_Click(object sender, RoutedEventArgs e)
        {
            ExaminationView examinationView = new ExaminationView { Tag = SubjectEnum.Net };
            NavigationService?.Navigate(examinationView);
        }

        private void BtnJava_OnClick(object sender, RoutedEventArgs e)
        {
            ExaminationView examinationView = new ExaminationView { Tag = SubjectEnum.Java };
            NavigationService?.Navigate(examinationView);
        }
    }
}
