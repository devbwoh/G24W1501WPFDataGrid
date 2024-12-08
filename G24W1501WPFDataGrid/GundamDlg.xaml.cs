using System.Windows;

namespace G24W1501WPFDataGrid;

public partial class GundamDlg : Window {
    public GundamDlg() {
        InitializeComponent();

        Name2.Focus();
    }
    //-----------------------------------
    // prop 탭 두 번
    //public int MyProperty { get; set; }
    //-----------------------------------

    //-----------------------------------
    // propfull 탭 두 번
    //private int myVar;

    //public int MyProperty {
    //    get { return myVar; }
    //    set { myVar = value; }
    //}
    //-----------------------------------

    // 현재 예제에서는 Control에 있는 Text 값 사용하므로,
    // Backing property는 사용하지 않음
    //private string _MSName;

    public string MSName {
        get { return Name2.Text; }
    }

    public string MSModel => Model.Text;

    public string MSParty => Party.Text;

    private void OnOK(object sender, RoutedEventArgs e) {
        if (string.IsNullOrEmpty(MSName)) {
            MessageBox.Show(
                "이름을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

            Name2.Focus();
            return;
        }
        if (string.IsNullOrEmpty(MSModel)) {
            MessageBox.Show(
                "모델을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

            Model.Focus();
            return;
        }
        if (string.IsNullOrEmpty(MSParty)) {
            MessageBox.Show(
                "소속을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

            Party.Focus();
            return;
        }

        DialogResult = true;
    }

    private void OnCancel(object sender, RoutedEventArgs e) {
        DialogResult = false;
    }
}
