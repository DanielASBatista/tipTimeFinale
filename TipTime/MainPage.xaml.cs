namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        double valorfinal; // Variável da classe, armazenando o valor com gorjeta

        public MainPage()
        {
            InitializeComponent();
            PorcentagemSlider.Value = 17; // Valor inicial do slider
        }

        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {
            double cima = Math.Ceiling(valorfinal);
            ValorFinalLabel.Text = $"R$ {cima:F2}";
        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {
            double baixo = Math.Floor(valorfinal);
            ValorFinalLabel.Text = $"R$ {baixo:F2}";
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
                double porcentagem = PorcentagemSlider.Value;
                PorcentagemGorjetalLabel.Text = $"{porcentagem}%";

                // Lê o valor digitado pelo usuário
                if (double.TryParse(ValorTotalEntry.Text, out double valortotal))
                {
                    double gorjeta = valortotal * (porcentagem / 100);
                    this.valorfinal = valortotal + gorjeta; // Salva no campo da classe

                    // Atualiza os rótulos com formatação
                    ValorGorjetaLabel.Text = $"R$ {gorjeta:F2}";
                    ValorFinalLabel.Text = $"R$ {this.valorfinal:F2}";
                }
                else
                {
                    // Se o valor digitado for inválido
                    ValorGorjetaLabel.Text = "Valor inválido";
                    ValorFinalLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ValorGorjetaLabel.Text = "Erro ao calcular";
                ValorFinalLabel.Text = "";
            }
        }
    }
}
