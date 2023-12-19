using casamento_conectado.Models;
using casamento_conectado.popups;
using casamento_conectado.Repositories;
using CommunityToolkit.Maui.Views;

using System.Collections.ObjectModel;

namespace casamento_conectado.Pages.Tabs;

public partial class FotosTab : ContentView
{
	
	public FotosTab()
	{
		InitializeComponent();
		listaImagens.ItemsSource = new ObservableCollection<Foto>(FotosRepository.Fotos);
	}

    private void AbrirPopup(object sender, EventArgs e)
    {
        Application.Current?.MainPage?.ShowPopup(new FotoPopup());
    }
}