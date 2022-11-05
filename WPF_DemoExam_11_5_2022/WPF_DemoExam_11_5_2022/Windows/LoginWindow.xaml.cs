using System;
using System.Windows;

using WPF_DemoExam_11_5_2022.Windows;

namespace WPF_DemoExam_11_5_2022.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод обработки нажатия кнопки "Зарегистрироваться"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            var RegistrationWindow = new RegistrationWindow();
            RegistrationWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Метод обработки нажатия кнопки "Войти"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
