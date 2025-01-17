using BMIApp.MVVM.ViewModels;

namespace BMIApp.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
        BindingContext = new BMIViewModel();
    }
}