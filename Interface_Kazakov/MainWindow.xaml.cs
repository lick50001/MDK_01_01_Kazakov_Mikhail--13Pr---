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
using Interface_Kazakov.Classes;

namespace Interface_Kazakov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UsersContext usersContext = new Classes.UsersContext();
        public MessagesContext messagesContext = new Classes.MessagesContext();
        public int IdSelectUser = -1;
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            LoadUser();
        }

        public void SelectUser(Models.Users User)
        {
            if (User != null)
                IdSelectUser = usersContext.AllUsers.FindIndex(x => x.Id == User.Id); // Используйте Id для поиска

            parentMessage.Children.Clear();
            var userMessages = MessagesContext.AllMessages.Where(m => m.IdUser == IdSelectUser).ToList();

            foreach (var messageModel in userMessages)
            {
                parentMessage.Children.Add(new Elements.Messages(messageModel));
            }

            BlockMessage.IsEnabled = true;
        }

        public void SendMessages(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (IdSelectUser == -1 || string.IsNullOrWhiteSpace(Message.Text)) return; 

                messagesContext.Save(Message.Text, DateTime.Now, IdSelectUser);

                Message.Text = "";

                SelectUser(usersContext.AllUsers[IdSelectUser]); 
            }
        }

        public void LoadUser()
        {
            foreach (Models.Users User in usersContext.AllUsers)
                ParentUser.Children.Add(new Elements.Users(User));
        }
    }
}
