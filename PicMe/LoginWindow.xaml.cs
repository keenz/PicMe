using System;
using System.Collections.Generic;
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
    public partial class LoginWindow : Window
    {
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Error string
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Designer
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();
            _mainGrid.DataContext = this;
            _lblError.Visibility = System.Windows.Visibility.Hidden;
        }

        /// <summary>
        /// Click button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnSignInClick(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Password))
            {
                Error = "Password is empty.";
                _lblError.Visibility = System.Windows.Visibility.Visible;
            }

            if (String.IsNullOrEmpty(UserName))
            {
                Error = "Username is empty.";
                _lblError.Visibility = System.Windows.Visibility.Visible;
            }

            if (!Auth(Password, UserName))
            {
                Error = "Your username or password was incorrect.";
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
    }
}
