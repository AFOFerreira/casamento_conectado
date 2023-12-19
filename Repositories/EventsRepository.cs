using casamento_conectado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casamento_conectado.Repositories
{
    public static class EventsRepository
    {
        public static List<Evento>? EventosCerimonia { get; private set; }
        public static List<Evento>? EventosFesta { get; private set; } 
        public static void CriarLista()
        {
            EventosCerimonia = new List<Evento>
            {
                new Evento("Entrada dos convidados","Convidados se acomodando em seus respectivos lugares!",StatusEvento.FINALIZADO,ImageSource.FromFile("convidados_cerimonia.svg")),
                new Evento("Incio da cerimônia","O noivo e sua mãe irão entrar!",StatusEvento.FINALIZADO,ImageSource.FromFile("entrada_noivo.svg")),
                new Evento("As madrinhas e os padrinhos estão entrando!","Olhe como eles estão chiques!",StatusEvento.FINALIZADO,ImageSource.FromFile("madrinhas_padrinhos.svg")),
                new Evento("Olha que Fofos","O Pajes e as Daminhas estão entrando!",StatusEvento.FINALIZADO,ImageSource.FromFile("daminhas_pajens.svg")),
                new Evento("Lá vem a noiva!","todos em pé para recebe-la!",StatusEvento.FINALIZADO,ImageSource.FromFile("noiva.svg")),
                new Evento("Lá vem as alianças!","Finalmente, a união esta selada!",StatusEvento.ANDAMENTO,ImageSource.FromFile("aliancas.svg")),
                new Evento("Cerimônia Finalizada","Os Convidados estão liberados para ir ao salão de festas!",StatusEvento.AGUARDANDO,ImageSource.FromFile("cerimonia_finalizada.svg")),
            };

            EventosFesta = new List<Evento>()
            {
                new Evento("Aproveite a entrada!","Os Garçons estão começando a servir as entradas!",StatusEvento.AGUARDANDO,ImageSource.FromFile("aperitivos.svg")),
                new Evento("O bar esta aberto!","Aproveite as bebidas, esta por conta da casa!",StatusEvento.AGUARDANDO,ImageSource.FromFile("bar.svg")),
                new Evento("A janta esta aberta!","Os noivos chegaram, e abriram a janta!",StatusEvento.AGUARDANDO,ImageSource.FromFile("janta.svg")),
                new Evento("Chegou a hora da valsa","Os noivos irão realizar sua dança de valsa",StatusEvento.AGUARDANDO,ImageSource.FromFile("valsa.svg")),
                new Evento("Aproveite a festa!","Agora esta livre para aproveitar a festa, tire fotos, registre os momentos!",StatusEvento.AGUARDANDO,ImageSource.FromFile("festa.svg")),
                new Evento("Obrigado por Comparecer!","Receba a sua lembraça com os noivos!",StatusEvento.AGUARDANDO,ImageSource.FromFile("fim_casamento.svg")),
            };
        }
    }
}
