namespace AnswerSystemWPF.IBLL
{
    public interface IValidationExceptionHandler
    {
        /// <summary>
        /// 是否有效
        /// </summary>
        bool IsValid
        {
            get;
            set;
        }
    }
}