using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using AnswerSystemWPF.BLL;
using AnswerSystemWPF.Body;
using AnswerSystemWPF.Command;
using AnswerSystemWPF.Helper;
using AnswerSystemWPF.IBLL;

namespace AnswerSystemWPF.ViewModel
{
    public class ExaminationViewModel : ViewModelBase
    {

        public ExaminationViewModel()
        {
            dt.Interval = TimeSpan.FromMilliseconds(8000);
            dt.Tick += SaveTopics;
            dt.Start();
        }

        private readonly IBLL.IReadLoader txtLoader = new TxtReadLoader();
        private DispatcherTimer dt = new DispatcherTimer();

        private SubjectEnum selectSubject;
        public SubjectEnum SelectSubject
        {
            get => selectSubject;
            set
            {
                selectSubject = value;

                if (ExaminationPaper == null)
                {
                    ExaminationPaper = new ExaminationPaper()
                    {
                        SubjectEnum = value,
                        CompleteTime = null,
                    };
                    ExaminationPaper.LoadTopics(txtLoader, AppSetting.Student);
                    Topics = ExaminationPaper.Topics;
                    SelectTopic = Topics.FirstOrDefault(t => string.IsNullOrWhiteSpace(t.AnSwer)) ?? Topics[0];
                }

                OnPropertyChanged(nameof(Topics));
            }
        }

        private ExaminationPaper ExaminationPaper;

        private ObservableCollection<Topic> topics;
        public ObservableCollection<Topic> Topics
        {
            get => topics;
            set
            {
                topics = value;
                OnPropertyChanged(nameof(Topics));
            }
        }

        private Topic selectTopic;
        public Topic SelectTopic
        {
            get => selectTopic;
            set
            {
                selectTopic = value;

                OnPropertyChanged(nameof(SelectTopic));
                OnPropertyChanged(nameof(Problem));
            }
        }

        public string Problem => SelectTopic?.Index + "." + SelectTopic?.Problem;

        public ICommand PrevCommand => new DelegateCommand(obj =>
        {
            if (SelectTopic != null && SelectTopic.Index > 1)
            {
                SelectTopic = Topics[SelectTopic.Index - 2];
            }
        });
        public ICommand NextCommand => new DelegateCommand(obj =>
        {
            if (SelectTopic != null && SelectTopic.Index < Topics.Count)
            {
                SelectTopic = Topics[SelectTopic.Index];
            }
        });
        public ICommand SubmitCommand => new DelegateCommand(obj =>
         {
             if (ExaminationPaper.ExamNullTopic())
             {
                 if (MessageBox.Show("你有题目未答完,确定要上传吗?", "提示",
                         MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
                 {
                     return;
                 }
             }

             Upload();

             MessageBox.Show("上传完成");
         });
        public ICommand SaveTopiCommand => new DelegateCommand(obj => { SaveTopics(null, null); });

        private void SaveTopics(object sender, EventArgs e)
        {
            ExaminationPaper?.SaveTopics(AppSetting.Student);
        }

        private void Upload()
        {
            Request r = new Request();

            r.Write("FileName", ExaminationPaper.GetFIleName(AppSetting.Student));
            r.Write("FileData", ExaminationPaper.Topics.ToList());
            r.Write("Title", ExaminationPaper.SubjectEnum.ToString());
            r.Write("Info", ExaminationPaper.GetInfo(AppSetting.Student));

            r.request("/Home/UploadExam");

            if (!r.ReadSuccess())
            {
                throw new Exception(r.ReadMessage());
            }
        }

    }
}
