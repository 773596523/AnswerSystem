using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AnswerSystemWPF
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.DragMove();
        }


        private void UIElement_OnKeyDown(object sender, KeyEventArgs e)
        {
            var ui = e.OriginalSource as UIElement;
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                if (ui == this.txtName)
                {
                    this.btnYes.Command.Execute(this);
                }
                else
                {
                    ui.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                }

            }
        }


        private void btnClose_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗", "提示", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
