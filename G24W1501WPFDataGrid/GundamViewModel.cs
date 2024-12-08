using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace G24W1501WPFDataGrid;

class GundamViewModel : INotifyPropertyChanged {
    private ObservableCollection<GundamModel> _gundamList
        = new ObservableCollection<GundamModel>();

    public ObservableCollection<GundamModel> GundamList => _gundamList;

    //---------------------------------------------
    private string _gundamImage = "";
    public string GundamImage => _gundamImage;

    //---------------------------------------------
    private GundamModel? _gundamSelected = null;
    public GundamModel? GundamSelected {
        get => _gundamSelected;
        set {
            if (value == null)
                return;

            if (_gundamSelected == value)
                return;

            _gundamSelected = value;
            _gundamImage = $"images/{_gundamSelected.Name}.jpg";
            OnPropertyChanged(nameof(GundamImage));
        }
    }

    //---------------------------------------------
    public void Add(GundamModel model) {
        _gundamList.Add(model);
    }

    //public void Select(GundamModel model) {
    //    _gundamImage = $"Images/{model.Name}.jpg";

    //    OnPropertyChanged(nameof(GundamImage));
    //}


    //---------------------------------------------
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
