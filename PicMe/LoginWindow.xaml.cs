using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PicMe
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// User Name
        /// </summary>
        private string _userName;

        /// <summary>
        /// User Name
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }

        /// <summary>
        /// Error message
        /// </summary>
        private string _errorMsg;

        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set
            {
                _errorMsg = value;
                OnPropertyChanged("ErrorMsg");    
            }
        }

        /// <summary>
        /// Designer
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();
            MainGrid.DataContext = this;
            TextBlock.Visibility = System.Windows.Visibility.Hidden;
        }

        /// <summary>
        /// Click button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnSignInClick(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CtrlPassword.Password))
            {
                ErrorMsg = "Password is empty.";
                TextBlock.Visibility = System.Windows.Visibility.Visible;
                return;
            }

            if (String.IsNullOrEmpty(UserName))
            {
                ErrorMsg = "Username is empty.";
                TextBlock.Visibility = System.Windows.Visibility.Visible;
                return;
            }

            if (!Auth(CtrlPassword.Password, UserName))
            {
                ErrorMsg = "Your username or password was incorrect.";
                TextBlock.Visibility = System.Windows.Visibility.Visible;
                return;
            }

            // auth is done
        }

        /// <summary>
        /// Authorization
        /// </summary>
        /// <param name="password"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        private bool Auth(string password, string userName)
        {

            return false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
