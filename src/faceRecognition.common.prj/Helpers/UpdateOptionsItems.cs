using ReactiveUI;
using FaceRecognition.Common.ViewModels;

namespace FaceRecognition.Common.Helpers;

/// <summary>Список параметров для выбора.</summary>
public sealed class UpdatedOptionsItems : ViewModelBase
{
	private bool _isEnabled;
	private bool _isEnabledItem;

	/// <summary>Наименование параметра.</summary>
	public string? Description { get; set; }

	/// <summary>Статус параметра.</summary>
	public bool IsChecked
	{
		get => _isEnabled;
		set => this.RaiseAndSetIfChanged(ref _isEnabled, value);
	}

	/// <summary>Доступность изменения параметра.</summary>
	public bool IsEnabledItem
	{
		get => _isEnabledItem;
		set => this.RaiseAndSetIfChanged(ref _isEnabledItem, value);
	}
}
