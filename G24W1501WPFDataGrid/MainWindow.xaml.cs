using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace G24W1501WPFDataGrid;

public partial class MainWindow : Window
{
    GundamViewModel vm = new GundamViewModel();

    public MainWindow()
    {
        InitializeComponent();

        DataContext = vm;

        GundamGrid.ItemsSource = vm.GundamList;

        vm.Add(new GundamModel("건담", "RX-78-2", "연방군"));
        vm.Add(new GundamModel("자쿠II", "MS-06", "지온군"));
    }

    private void OnAdd(object sender, RoutedEventArgs e) {
        GundamDlg dlg = new GundamDlg();
        if (dlg.ShowDialog() != true)
            return;

        vm.Add(new GundamModel(dlg.MSName, dlg.MSModel, dlg.MSParty));
    }

    //private void OnSelect(object sender, RoutedEventArgs e) {
    //    GundamModel ms = (GundamModel)GundamGrid.SelectedItem;

    //    ////        BitmapImage image = new BitmapImage(new Uri("Images/건담.jpg",
    //    //        BitmapImage image = new BitmapImage(new Uri($"Images/{ms.Name}.jpg",
    //    //            UriKind.Relative));

    //    //        GundamImage.Source = image;

    //    vm.Select(ms);
    //}
}