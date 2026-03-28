using MauiAppListaCompras.Models;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MauiAppListaCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_Descricao.Text,
				Quantidade = Convert.ToDouble(txt_Quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.insert(p);
			await DisplayAlert("Sucesso!", "Registro inserido", "Ok");
			await Navigation.PopAsync();

        } catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "'Ok");
		}
    }
}