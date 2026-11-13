using System.Globalization;
using CadastroEventos.Models;

namespace CadastroEventos;
public partial class MainPage : ContentPage
{
    private readonly Evento _evento = new();
    public MainPage()
    {
        InitializeComponent();
        BindingContext = _evento;
    }

    private async void Cadastrar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_evento.Nome) || string.IsNullOrWhiteSpace(_evento.Local))
        {
            await DisplayAlert("Atenção", "Informe o nome e o local do evento.", "OK");
            return;
        }
        if (_evento.DataTermino.Date < _evento.DataInicio.Date)
        {
            await DisplayAlert("Atenção", "A data de término não pode ser anterior à data de início.", "OK");
            return;
        }
        if (!int.TryParse(ParticipantesEntry.Text, out var participantes) || participantes <= 0)
        {
            await DisplayAlert("Atenção", "Informe um número válido de participantes, maior que zero.", "OK");
            return;
        }
        var textoCusto = CustoEntry.Text?.Trim() ?? "";
        if (!decimal.TryParse(textoCusto, NumberStyles.Number, CultureInfo.GetCultureInfo("pt-BR"), out var custo)
            && !decimal.TryParse(textoCusto, NumberStyles.Number, CultureInfo.InvariantCulture, out custo))
        {
            await DisplayAlert("Atenção", "Informe um custo válido, por exemplo 25,50.", "OK");
            return;
        }
        if (custo < 0)
        {
            await DisplayAlert("Atenção", "O custo não pode ser negativo.", "OK");
            return;
        }
        _evento.NumeroParticipantes = participantes;
        _evento.CustoPorParticipante = custo;
        await Navigation.PushAsync(new ResumoPage { BindingContext = _evento });
    }
}
