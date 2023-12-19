using casamento_conectado.Repositories;

namespace casamento_conectado.Pages.Tabs;

public partial class AvaliacaoTab : ContentView
{
	public AvaliacaoTab()
	{
		InitializeComponent();
		listaBebidas.ItemsSource = AvaliacaoRepository.BebidasBar;
        listaPratosPrincipais.ItemsSource = AvaliacaoRepository.PratosPrincipais;
        listaSobremesas.ItemsSource = AvaliacaoRepository.Sobremesa;
        listaAcompanhamento.ItemsSource = AvaliacaoRepository.Acompanhamento;
        listaAperitivos.ItemsSource = AvaliacaoRepository.Aperitivos;
        listaMusica.ItemsSource = AvaliacaoRepository.Musica;
        listaLocal.ItemsSource = AvaliacaoRepository.Local;

	}
}