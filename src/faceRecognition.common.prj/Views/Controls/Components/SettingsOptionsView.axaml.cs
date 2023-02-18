using Avalonia.Collections;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FaceRecognition.Common.Helpers;

namespace FaceRecognition.Common.Views.Controls.Components;

public partial class SettingsOptionsView : UserControl
{
	public static readonly StyledProperty<AvaloniaList<UpdatedOptionsItems>> UpdatedOptionsItemsProperty =
		AvaloniaProperty.Register<SettingsOptionsView, AvaloniaList<UpdatedOptionsItems>>(nameof(UpdatedOptionsItems), new());

	public AvaloniaList<UpdatedOptionsItems> UpdatedOptionsItems
	{
		get => GetValue(UpdatedOptionsItemsProperty);
		set => SetValue(UpdatedOptionsItemsProperty, value);
	}

	public SettingsOptionsView()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}
