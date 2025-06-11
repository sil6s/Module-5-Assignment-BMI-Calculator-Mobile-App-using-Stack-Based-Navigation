// Silas Curry mobile app dev
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace SilasNewBMIApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set up stack-based navigation with styling
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Colors.White, // Navigation bar background
                BarTextColor = Colors.Black        // Navigation bar text color
            };
        }
    }
}
