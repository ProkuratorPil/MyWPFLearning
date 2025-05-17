using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWPFLearning.ViewModels.Base;

namespace MyWPFLearning.ViewModels
{
    internal class MainWindowsViewModel : ViewModel
    {
        #region Заголовок окна
        private string _title = "Анализ статистики";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion
    }
}
