using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text.Json.Nodes;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Data;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using WpfApp1.MODELS;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PassangerDataCollection passangerDataCollection;
        public MainWindow()
        {
            passangerDataCollection = new PassangerDataCollection();
            InitializeComponent();

            memberDataGrid.DataContext = passangerDataCollection.passangers;


        }
        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount.Equals(2))
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
            }
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton.Equals(MouseButton.Left))
            {
                this.DragMove();
            }
        }

        private void Button_Click_App_Exit(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click_Open_File(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == true)
            {
                if (Path.GetExtension(OPF.FileName).Equals(".json"))
                    using (StreamReader streamReader = new StreamReader(OPF.FileName))
                    {
                        string json = streamReader.ReadToEnd();                        
                        passangerDataCollection.passangers =  JsonConvert.DeserializeObject<ObservableCollection<Passangers>>(json);
                        memberDataGrid.DataContext = passangerDataCollection.passangers;
                    }
            }
        }
    }
}
