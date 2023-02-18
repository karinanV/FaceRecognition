using System.Reactive;
using Avalonia.Platform.Storage;
using ReactiveUI;

namespace FaceRecognition.Common.Services.Dialogs;

public class FileDialogInteractionSource
{
	private IStorageProvider _storageProvider;

	public FileDialogInteractionSource(IStorageProvider storageProvider)
	{
		_storageProvider = storageProvider;
	}

	/// <summary>Открытие окна для выбора файла.</summary>
	/// <param name="interaction">Взаимодействие открытия выбора файла.</param>
	/// <param name="storageProvider">Проводник.</param>
	/// <returns></returns>
	public async Task DoShowDialog(InteractionContext<Unit, string?> interaction)
	{
		var dialog = await _storageProvider.OpenFilePickerAsync(new FilePickerOpenOptions()
		{
			AllowMultiple = false,
			Title = "Open Video File",
			FileTypeFilter = new List<FilePickerFileType>()
			{
				new FilePickerFileType("Video Files ( *.mp4 *.avi *.ts *.mkv *.mov *.wmv *.m4v )")
				{
					Patterns = new List<string>{ "*.mp4", "*.avi", "*.ts", "*.mkv", "*.mov", "*.wmv", "*.m4v" },
				},
				new FilePickerFileType("Image Files ( *.png *.jpg *.bmp *.gif )")
				{
					Patterns = new List<string>{ "*.png", "*.jpg", "*.bmp", "*.gif" },
				},
				new FilePickerFileType("All Files")
				{
					Patterns = new List<string>() { "*.*" },
				},
			},
		});

		var file = dialog.Select(x => x).FirstOrDefault();
		if(file != default && file.CanOpenRead)
		{
			interaction.SetOutput(file.Path.OriginalString);
		}
		else
		{
			interaction.SetOutput(default);
		}
	}
}

