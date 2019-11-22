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

namespace AnswerSystemWPF.View
{
    /// <summary>
    /// ExaminationView.xaml 的交互逻辑
    /// </summary>
    public partial class ExaminationView : Page
    {
        public ExaminationView()
        {
            InitializeComponent();
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.txtAnSwer.Focus();
            this.txtAnSwer.SelectionStart = this.txtAnSwer.Text.Length;
        }

        private void BtnReturn_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
