using System.ComponentModel;
using System.Runtime.CompilerServices;

using ReactiveUI;

namespace FaceRecognition.Common.ViewModels;

public class ViewModelBase : ReactiveObject
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
