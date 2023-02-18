using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

using FaceRecognition.Gui.ViewModels;

namespace FaceRecognition.Gui.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
		InitializeComponent();
    }

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}
