using BMIApp.MVVM.Views;

namespace BMIApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BMIView();
        }
    }
}
