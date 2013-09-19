// Sample.Plugin
// SampleView.xaml.cs

namespace Sample.Plugin.Views
{
    /// <summary>
    ///     Interaction logic for SampleView.xaml
    /// </summary>
    public partial class SampleView
    {
        public static SampleView View;

        public SampleView()
        {
            InitializeComponent();
            View = this;
        }
    }
}
