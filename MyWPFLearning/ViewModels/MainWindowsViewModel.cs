using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MyWPFLearning.Infrasturcture.Commands;
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


        #region Status: string - Статус бар
        /// <summary> Статус бар </summary>
        private string _Status;
				/// <summary> Статус бар </summary>
				public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #region Команды
        
        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #endregion

        public MainWindowsViewModel()
        {
            #region Команды

            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            #endregion
        }



    }
}
