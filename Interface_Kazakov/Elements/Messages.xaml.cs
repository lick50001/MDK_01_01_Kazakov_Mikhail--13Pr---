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

namespace Interface_Kazakov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Messages.xaml
    /// </summary>
    public partial class Messages : UserControl
    {
        public Interface_Kazakov.Models.Messages ThisMessageModel;
        public Messages(Interface_Kazakov.Models.Messages messageModel)
        {
            InitializeComponent();
            ThisMessageModel = messageModel; 
            Message.Text = messageModel.Message; 
            Date.Text = messageModel.Create.ToString("dd.MM.yyyy"); 
        }

        private void DeleteMessage(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var mainWin = MainWindow.mainWindow;
            if (mainWin != null)
            {
                // Удаляем сообщение по Id
                mainWin.messagesContext.Delete(ThisMessageModel.Id);
                MainWindow.mainWindow.parentMessage.Children.Remove(this);
            }
        }
    }
}
