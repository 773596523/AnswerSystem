using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace AnswerSystemWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitWindow();
        }

        private void InitWindow()
        {
            this.MaxWidth = SystemParameters.WorkArea.Width;
            this.MaxHeight = SystemParameters.WorkArea.Height;
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗", "提示", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
