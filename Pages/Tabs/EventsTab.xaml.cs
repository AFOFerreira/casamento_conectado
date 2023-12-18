using System.Collections.ObjectModel;

namespace casamento_conectado.Pages.Tabs;

public enum StatusEvento
{

    AGUARDANDO = 0,
    ANDAMENTO = 1,
    FINALIZADO = 2,
}

public class Evento
{
    public String Titulo { get; set; }
    public StatusEvento Status { get; set; }
    public string Descricao { get; set; }
    public ImageSource Imagem { get; set; }
    public string StatusDescricao { get => Status.ToString(); }
    public Color CorStatus
    {
        get
        {
            switch (Status)
            {
                case StatusEvento.AGUARDANDO:
                    return Colors.Red;
                case StatusEvento.ANDAMENTO:
                    return Colors.Orange;
                case StatusEvento.FINALIZADO:
                    return Colors.Green;
                default
                    : return Colors.Black;
            }
        }
    }
}

public partial class EventsTab : ContentView
{
    public List<Evento> EventosCerimonia { get; set; } = new List<Evento>
    {
        new Evento(){
            Titulo = "Entrada dos convidados",
            Descricao = "Convidados se acomodando em seus respectivos lugares!",
            Status = StatusEvento.FINALIZADO,
            Imagem = ImageSource.FromFile("convidados_cerimonia.svg")
        },
        new Evento(){
            Titulo = "Incio da cerim�nia",
            Descricao = "O noivo e sua m�e ir�o entrar!",
            Status = StatusEvento.FINALIZADO,
               Imagem = ImageSource.FromFile("entrada_noivo.svg")
        },
        new Evento(){
            Titulo = "As madrinhas e os padrinhos est�o entrando!",
            Descricao = "Olhe como eles est�o chiques!",
            Status = StatusEvento.FINALIZADO,
               Imagem = ImageSource.FromFile("madrinhas_padrinhos.svg")
        },
        new Evento(){
            Titulo = "Olha que Fofos",
            Descricao = "O Pajes e as Daminhas est�o entrando!",
            Status = StatusEvento.FINALIZADO,
               Imagem = ImageSource.FromFile("daminhas_pajens.svg")
        },
        new Evento(){
            Titulo = "L� vem a noiva!",
            Descricao = "todos em p� para recebe-la!",
            Status = StatusEvento.FINALIZADO,
               Imagem = ImageSource.FromFile("noiva.svg")
        },
        new Evento(){
            Titulo = "L� vem as alian�as!",
            Descricao = "Finalmente, a uni�o esta selada!",
            Status = StatusEvento.ANDAMENTO,
               Imagem = ImageSource.FromFile("aliancas.svg")
        }, 
        new Evento(){
            Titulo = "Cerim�nia Finalizada",
            Descricao = "Os Convidados est�o liberados para ir ao sal�o de festas!",
            Status = StatusEvento.AGUARDANDO,
               Imagem = ImageSource.FromFile("cerimonia_finalizada.svg")
        },     
    };
    public List<Evento> EventosFesta { get; set; } = new List<Evento>()
    {
         new Evento(){
            Titulo = "Aproveite a entrada!",
            Descricao = "Os Gar�ons est�o come�ando a servir as entradas!",
            Status = StatusEvento.AGUARDANDO,
              Imagem = ImageSource.FromFile("aperitivos.svg")
        },
        new Evento(){
            Titulo = "O bar esta aberto!",
            Descricao = "Aproveite as bebidas, esta por conta da casa!",
            Status = StatusEvento.AGUARDANDO,
              Imagem = ImageSource.FromFile("bar.svg")
        },
        new Evento(){
            Titulo = "A janta esta aberta!",
            Descricao = "Os noivos chegaram, e abriram a janta!",
            Status = StatusEvento.AGUARDANDO,
              Imagem = ImageSource.FromFile("janta.svg")
        },
        new Evento(){
            Titulo = "Chegou a hora da valsa",
            Descricao = "Os noivos ir�o realizar sua dan�a de valsa",
            Status = StatusEvento.AGUARDANDO,
              Imagem = ImageSource.FromFile("valsa.svg")
        },
        new Evento(){
            Titulo = "Aproveite a festa!",
            Descricao = "Agora esta livre para aproveitar a festa, tire fotos, registre os momentos!",
            Status = StatusEvento.AGUARDANDO,
              Imagem = ImageSource.FromFile("festa.svg")
        },
        new Evento(){
            Titulo = "Obrigado por Comparecer!",
            Descricao = "Receba a sua lembra�a com os noivos!",
            Status = StatusEvento.AGUARDANDO,
              Imagem = ImageSource.FromFile("fim_casamento.svg")
        },
     
    };


    public EventsTab()
    {
        InitializeComponent();
        listaCerimonia.ItemsSource = new ObservableCollection<Evento>(EventosCerimonia);
        listaFesta.ItemsSource = new ObservableCollection<Evento>(EventosFesta);
    }
}
