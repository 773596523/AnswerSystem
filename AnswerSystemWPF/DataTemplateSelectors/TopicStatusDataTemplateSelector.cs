using System.Windows;
using System.Windows.Controls;

namespace AnswerSystemWPF.DataTemplateSelectors
{
    public class TopicStatusDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            return base.SelectTemplate(item, container);
        }
    }
}