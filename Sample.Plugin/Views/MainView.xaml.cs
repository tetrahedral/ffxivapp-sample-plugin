// Sample.Plugin
// MainView.xaml.cs

namespace Sample.Plugin.Views
{
    /// <summary>
    ///     Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView
    {
        public static MainView View;

        public MainView()
        {
            InitializeComponent();
            View = this;
        }
    }
}
