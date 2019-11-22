using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Interactivity;
using AnswerSystemWPF.Adorners;
using AnswerSystemWPF.IBLL;

namespace AnswerSystemWPF.Behaviors
{
    /// <summary>
    /// 验证行为类,可以获得附加到的对象
    /// </summary>
    public class ValidationExceptionBehavior : Behavior<FrameworkElement>
    {

        /// <summary>
        /// 错误计数器
        /// </summary>
        private int _validationExceptionCount = 0;

        private Dictionary<UIElement, NotifyAdorner> _adornerCache;

        /// <summary>
        /// 附加对象时
        /// </summary>
        protected override void OnAttached()
        {
            _adornerCache = new Dictionary<UIElement, NotifyAdorner>();

            //附加对象时，给对象增加一个监听验证错误事件的能力，注意该事件是冒泡的
            this.AssociatedObject.AddHandler(Validation.ErrorEvent, new EventHandler<ValidationErrorEventArgs>(this.OnValidationError));
        }


        /// <summary>
        /// 获取对象
        /// </summary>
        /// <returns></returns>
        private IValidationExceptionHandler GetValidationExceptionHandler()
        {
            if (this.AssociatedObject.DataContext is IValidationExceptionHandler handler)
            {
                return handler;
            }

            return null;
        }


        /// <summary>
        /// 显示Adorner
        /// </summary>
        /// <param name="element"></param>
        /// <param name="errorMessage"></param>
        private void ShowAdorner(UIElement element, string errorMessage)
        {
            NotifyAdorner adorner = null;

            //先去缓存找
            if (_adornerCache.ContainsKey(element))
            {
                adorner = _adornerCache[element];

                //找到了，修改提示信息
                adorner.ChangeToolTip(errorMessage);
            }
            //没有找到，那就New一个，加入到缓存
            else
            {
                adorner = new NotifyAdorner(element, errorMessage);

                _adornerCache.Add(element, adorner);

            }

            //将Adorner加入到
            {
                var adornerLayer = AdornerLayer.GetAdornerLayer(element);
                if (adorner.Parent == null)
                {
                    adornerLayer.Add(adorner);
                }

            }
        }
        /// <summary>
        /// 移除Adorner
        /// </summary>
        /// <param name="element"></param>
        private void HideAdorner(UIElement element)
        {
            //移除Adorner
            if (_adornerCache.ContainsKey(element))
            {
                var adorner = _adornerCache[element];

                var adornerLayer = AdornerLayer.GetAdornerLayer(element);

                adornerLayer.Remove(adorner);
            }
        }


        /// <summary>
        /// 验证事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnValidationError(object sender, ValidationErrorEventArgs e)
        {
            try
            {
                var handler = GetValidationExceptionHandler();

                var element = e.OriginalSource as UIElement;

                if (handler == null || element == null)
                    return;

                if (e.Action == ValidationErrorEventAction.Added)
                {
                    _validationExceptionCount++;

                    //ShowAdorner(element, e.Error.ErrorContent.ToString());
                }
                else if (e.Action == ValidationErrorEventAction.Removed)
                {
                    _validationExceptionCount--;

                    // HideAdorner(element);
                }

                handler.IsValid = _validationExceptionCount == 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}