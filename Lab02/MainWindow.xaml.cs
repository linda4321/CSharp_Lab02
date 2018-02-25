using System.Windows;
using FontAwesome.WPF;

namespace CSharpLab02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageAwesome _loader;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AddPersonViewModel(ShowLoader);
        }

        private void ShowLoader(bool isShow)
        {
            LoaderHelper.OnRequestLoader(MainGrid, ref _loader, isShow);
        }
    }
}
