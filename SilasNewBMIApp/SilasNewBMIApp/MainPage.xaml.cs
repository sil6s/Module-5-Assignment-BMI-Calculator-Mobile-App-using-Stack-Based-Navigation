using Microsoft.Maui.Controls;

namespace SilasNewBMIApp
{
    public partial class MainPage : ContentPage
    {
        private string _gender = "Male";

        public MainPage()
        {
            InitializeComponent();
            HighlightGender();
            UpdateSliderLabels();
        }

        void OnMaleTapped(object sender, EventArgs e)
        {
            _gender = "Male";
            HighlightGender();
        }

        void OnFemaleTapped(object sender, EventArgs e)
        {
            _gender = "Female";
            HighlightGender();
        }

        void HighlightGender()
        {
            MaleFrame.BorderColor = _gender == "Male" ? Colors.Blue : Colors.Transparent;
            FemaleFrame.BorderColor = _gender == "Female" ? Colors.DeepPink : Colors.Transparent;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateSliderLabels();
        }

        void UpdateSliderLabels()
        {
            HeightValueLabel.Text = $"Height: {HeightSlider.Value:F0} in";
            WeightValueLabel.Text = $"Weight: {WeightSlider.Value:F0} lb";
        }

        async void OnCalculateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BMIDetailPage(WeightSlider.Value, HeightSlider.Value, _gender));
        }
    }
}
