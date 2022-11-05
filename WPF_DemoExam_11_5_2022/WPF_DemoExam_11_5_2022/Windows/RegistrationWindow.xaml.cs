using System;
using System.Windows;

using WPF_DemoExam_11_5_2022.Windows;

namespace WPF_DemoExam_11_5_2022.Windows
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод обработки нажатия кнопки "Авторизоваться"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Метод обработки нажатия кнопки "Зарегистрироваться"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
