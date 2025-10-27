using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interface_Kazakov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        public Models.Users ThisUser;
        public Users(Models.Users User)
        {
            InitializeComponent();
            ThisUser = User;
            FIO.Text = User.FIO;
        }

        private void SelectUser(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MainWindow.mainWindow.SelectUser(ThisUser);
        }
        
    }
}
