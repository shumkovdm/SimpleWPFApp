using System.Windows;

namespace SimpleWPFApp
{
    public partial class MainWindow : Window
    {
        private int _counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            NumberListView.Items.Add(_counter++);
        }

        private void DelButton(object sender, RoutedEventArgs e)
        {
            if (NumberListView.SelectedItem != null)
                NumberListView.Items.Remove(NumberListView.SelectedItem);
        }

        private void ClearButton(object sender, RoutedEventArgs e)
        {
            NumberListView.Items.Clear();
            _counter = 0;
        }
    }
}