using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AttachedPropertyDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var tb = this.FindControl<TextBlock>("tb");
            var test = Demo.GeTest(tb);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}