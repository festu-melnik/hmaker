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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HMaker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Initialized(object sender, EventArgs e)
        {
            TagsSource source = new TagsSource();
            source.Connect("Data Source = tags.db3");
            TagInfo[] tags = source.ReceiveTagsInfo();

            foreach (TagInfo t in tags)
            {
                MessageBox.Show(String.Format("{0} - {1}", t.Name, t.Description));
            }
        }
    }
}
