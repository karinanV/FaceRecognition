using Avalonia.Controls;
using Avalonia.Platform;

namespace FaceRecognition.Common.Services.IconProvider;

/// <inheritdoc/>
public class ApplicationIconProvider : IApplicationIconProvider
{
	public WindowIcon Icon { get; }

	/// <summary>Создаёт экземпляр класса <see cref="ApplicationIconProvider"/>.</summary>
	/// <param name="loader">Загрузчик иконок.</param>
	public ApplicationIconProvider(IAssetLoader loader, string iconPath)
	{
		Icon = new WindowIcon(loader.Open(new Uri(iconPath)));
	}
}
