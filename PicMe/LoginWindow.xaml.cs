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
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Error string
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Designer
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();
            _mainGrid.DataContext = this;
            ErrorMsg = "No error";
            //_lblError.Visibility = System.Windows.Visibility.Hidden;
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
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ErrorMsg"));
                
                _lblError.Visibility = System.Windows.Visibility.Visible;
            }

            if (String.IsNullOrEmpty(UserName))
            {
                ErrorMsg = "Username is empty.";                
                _lblError.Visibility = System.Windows.Visibility.Visible;
            }

            if (!Auth(CtrlPassword.Password, UserName))
            {
                UserName = "Your username or password was incorrect.";
                ErrorMsg = "Your username or password was incorrect.";
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ErrorMsg"));
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
                _lblError.Visibility = System.Windows.Visibility.Visible;
            }
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
