using casamento_conectado.Models;
using casamento_conectado.Repositories;
using System.Collections.ObjectModel;

namespace casamento_conectado.Pages.Tabs;

public partial class EventsTab : ContentView
{
    public EventsTab()
    {
        InitializeComponent();
        listaCerimonia.ItemsSource = new ObservableCollection<Evento>(EventsRepository.EventosCerimonia ?? new List<Evento>());
        listaCerimonia.ScrollTo(null, animate: false);

        listaFesta.ItemsSource = new ObservableCollection<Evento>(EventsRepository.EventosFesta ?? new List<Evento>());
        listaFesta.ScrollTo(null, animate: false);
    }
}
