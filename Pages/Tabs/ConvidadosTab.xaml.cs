using casamento_conectado.Models;
using casamento_conectado.Repositories;
using System.Collections.ObjectModel;

namespace casamento_conectado.Pages.Tabs;

public partial class ConvidadosTab : ContentView
{
   
    public ConvidadosTab()
    {
        InitializeComponent();
        listaConvidados.ItemsSource =new ObservableCollection<Convidado> (ConvidadosRepository.Convidados?.OrderByDescending(x=> x.Presente).ToList()?? new List<Convidado>());
    }
}