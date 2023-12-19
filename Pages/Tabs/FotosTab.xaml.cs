using casamento_conectado.Models;
using casamento_conectado.Repositories;
using System.Collections.ObjectModel;

namespace casamento_conectado.Pages.Tabs;

public partial class FotosTab : ContentView
{
	
	public FotosTab()
	{
		InitializeComponent();
		listaImagens.ItemsSource = new ObservableCollection<Foto>(FotosRepository.Fotos);
	}
}