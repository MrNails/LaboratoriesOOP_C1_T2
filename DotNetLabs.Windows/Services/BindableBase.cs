using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DotNetLabs.Windows.Services;

public abstract class BindableBase : INotifyPropertyChanged, IDataErrorInfo
{
    protected Dictionary<string, string> Errors { get; } = new Dictionary<string, string>();

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    public string Error => Errors.FirstOrDefault().Value ?? string.Empty;

    public string this[string columnName] => Errors.TryGetValue(columnName, out var error) ? error : string.Empty;
}