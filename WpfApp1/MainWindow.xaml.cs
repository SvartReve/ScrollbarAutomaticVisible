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

namespace WpfApp1
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

        public int btnUp = 0;
      

        private void scrollBar_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if(e.HorizontalOffset != 0)
            {
                scrollBar.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
            }
            if(e.VerticalChange != 0)
            {
                scrollBar.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            }


        }

        private void scrollBar_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
            {
                scrollBar.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            }
            if (e.LeftButton == MouseButtonState.Released)
            {
                scrollBar.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            }
        }
    }
}
