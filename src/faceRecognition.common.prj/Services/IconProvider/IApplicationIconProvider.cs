using Avalonia.Controls;

namespace FaceRecognition.Common.Services.IconProvider;

/// <summary>Иконка для окон.</summary>
public interface IApplicationIconProvider
{
	public WindowIcon Icon { get; }
}
