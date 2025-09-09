namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            PorcentagemSlider.Value = 17;
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
            try 
            {
                double porcentegem = PorcentagemSlider.Value;
                PorcentagemGorjetaLabel.Text = $"{porcentegem}%";
                //double gorjeta;
                double valortotal = double.Parse(ValorTotalEntry.Text);
                //double valortotal = Convert.ToDouble(ValorTotalEntry.Text);
                //convert é uma classe
                double gorjeta = valortotal * (porcentegem / 100);
                double valorfinal = valortotal + gorjeta;
                //estamos interpolando uma variável que tem conteudo numero em umastring
                //ValorGorjetaLabel.Text = $"R$ {gorjeta}";
                //Orecurso de cima não é muito bom
                //O recurso de baixo é melhor porque o caracter c entre aspas determina a
                //correta moeda de acordo com as configurações do sistema operacional e
                //alem disso faz a aproximação sempre para duas casas decimais porque
                //sabe que estamos trabalhando valores monetários
                ValorGorjetaLabel.Text = gorjeta.ToString("c");
                ValorFinalLabel.Text = valorfinal.ToString("c");
                //ValorFinalLabel.Text = $"R$ {valorfinal}";
            }
            catch (Exception ex)
            {
                //Toda vez que uso o comando Console.WriteLine a saída vai para a
                //console na aba Output
                Console.WriteLine(ex.ToString() );
                //O Alert não é eficiente pois quebra a navegação do usuário
                //DisplayAlert("Erro", "Digite um valor numérico váildo","OK");
            }
        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
