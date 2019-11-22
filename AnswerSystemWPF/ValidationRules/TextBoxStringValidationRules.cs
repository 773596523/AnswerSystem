using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AnswerSystemWPF.ValidationRules
{
    public class TextBoxStringValidationRules : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult(false, "内容不能为空!");
            }
            Regex re = new Regex(@"^[\u4E00-\u9FA5A-Za-z0-9_]+$");
            if (!re.IsMatch(value.ToString()))
            {
                return new ValidationResult(false, "不允许有特殊字符!");
            }

            return new ValidationResult(true, null);
        }
    }
}
