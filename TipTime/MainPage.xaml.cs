namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double Total = double.Parse(ValorTotalEntry.Text);
            double Slider = double.Parse(Porcentagem15Btn);
            Total = Total * (Slider / 100);

        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
