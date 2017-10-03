using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace FluentMigrator.UiEditor
{
    public class MainWindowVm
    {
        #region -- OpenCommand --
        public ICommand OpenCommand => new RelayCommand(OpenCommandExecute, () => false);

        private void OpenCommandExecute()
        {
            throw new System.NotImplementedException();
        }

        #endregion -- OpenCommand --

        #region -- SaveCommand --
        public ICommand SaveCommand => new RelayCommand(SaveCommandExecute, () => false);

        private void SaveCommandExecute()
        {
            throw new System.NotImplementedException();
        }

        #endregion -- SaveCommand --

        #region -- QuitCommand --
        public ICommand QuitCommand => new RelayCommand(QuitCommandExecute, () => true);

        private void QuitCommandExecute()
        {
            Application.Current.MainWindow.Close();
        }

        #endregion -- QuitCommand --
    }
}