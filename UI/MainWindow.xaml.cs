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

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TagsSource source = new TagsSource();
            source.Connect("Data Source = tags.db3");
            TagInfo[] tags = source.ReceiveTagsInfo();
            Button[] buttons = new Button[tags.Length];

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Content = tags[i].Name;
                buttons[i].Tag = tags[i].Description;
                buttons[i].Width = 50;
                buttons[i].Height = 50;
                buttons[i].Click += (object s, RoutedEventArgs args) =>
                    {
                        MessageBox.Show(String.Format("Выбран тег {0}", ((Button)s).Content));
                    };
                tagsPanel.Children.Add(buttons[i]);
            }

            //Button new_tag = new Button();
            //new_tag.Content = "+";
            //new_tag.Width = 45;
            //new_tag.Height = 30;
            //tagsPanel.Children.Add(new_tag);

            
        }
    }
}
