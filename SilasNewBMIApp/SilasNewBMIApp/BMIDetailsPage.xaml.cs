using Microsoft.Maui.Controls;

namespace SilasNewBMIApp
{
    public partial class BMIDetailPage : ContentPage
    {
        private readonly double _bmi;
        private readonly string _status;
        private readonly string _gender;

        public BMIDetailPage(double weight, double height, string gender)
        {
            InitializeComponent();
            _gender = gender;
            _bmi = height > 0 ? (weight * 703) / (height * height) : 0;
            _status = GetHealthStatus(_bmi, _gender);

            BmiLabel.Text = $"Your BMI: {_bmi:F1}";
            CategoryLabel.Text = $"Status: {_status}";
        }

        private string GetHealthStatus(double bmi, string gender)
        {
            if (gender == "Male")
            {
                if (bmi < 18.5) return "Underweight";
                if (bmi < 25) return "Normal";
                if (bmi < 30) return "Overweight";
                return "Obese";
            }
            else
            {
                if (bmi < 18) return "Underweight";
                if (bmi < 24) return "Normal";
                if (bmi < 29) return "Overweight";
                return "Obese";
            }
        }

        private async void OnNextClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecommendationsPage(_status, _gender));
        }

        private async void OnBackToInputClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
