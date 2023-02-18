using ReactiveUI;
using FaceRecognition.Common.Helpers;

namespace FaceRecognition.Common.Services.Dialogs;

/// <summary>Создаёт взаимодействия открытия для моделей представления.</summary>
public class DialogServiceInteractions
{
	/// <summary>Вопрос перед действием.</summary>
	public Interaction<MessageContent, bool> ShowQuestionMessage { get; set; } = new();

	/// <summary>Уведомление об ошибке.</summary>
	public Interaction<MessageContent, bool> ShowErrorMessage { get; set; } = new();

	/// <summary>Закрытие окна.</summary>
	public Interaction<bool, bool> CloseWindow { get; set; } = new();

	/// <summary>Создаёт экземпляр класса <see cref="DialogServiceInteractions"/>.</summary>
	public DialogServiceInteractions()
	{

	}
}