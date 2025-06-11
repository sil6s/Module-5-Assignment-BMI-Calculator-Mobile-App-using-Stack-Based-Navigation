using Microsoft.Maui.Controls;

namespace SilasNewBMIApp
{
    public partial class RecommendationsPage : ContentPage
    {
        public RecommendationsPage(string status, string gender)
        {
            InitializeComponent();
            RecommendationLabel.Text = GetRecommendation(status);
        }

        private string GetRecommendation(string status) => status switch
        {
            "Underweight" => "Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains). Incorporate strength training. Consult a nutritionist if needed.",
            "Normal" => "Maintain a balanced diet with proteins, healthy fats, and fiber. Exercise regularly and monitor health.",
            "Overweight" => "Reduce processed foods. Engage in regular aerobic exercises. Drink plenty of water and track progress.",
            "Obese" => "Consult a doctor. Start with low-impact exercises. Follow a weight-loss meal plan and behavioral support.",
            _ => "Stay healthy and consult a professional for personalized advice."
        };

        private async void OnBackToBMIResultClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Go back to BMI result page
        }

        private async void OnBackToInputClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); // Go all the way back to MainPage
        }
    }
}
