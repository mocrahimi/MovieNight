using MovieNight.Views;
using System.Windows;

namespace MovieNight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TvShowsView moviesView = new TvShowsView();
            Controller.Content = moviesView;
        }
    }
}
