using System.Collections.ObjectModel;

namespace MauiCollectionViewBug;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Collection { get; } = ["This is some text", "This is more text"];

    public MainPage()
    {
        BindingContext = this;
        InitializeComponent();
    }

}
