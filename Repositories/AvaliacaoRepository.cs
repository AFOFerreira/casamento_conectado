using casamento_conectado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casamento_conectado.Repositories
{
    public static class AvaliacaoRepository
    {
        public static List<Avaliacao>? BebidasBar{ get; set; }     
        public static List<Avaliacao>? Aperitivos{ get; set; }     
        public static List<Avaliacao>? PratosPrincipais{ get; set; }     
        public static List<Avaliacao>? Sobremesa{ get; set; }     
        public static List<Avaliacao>? Acompanhamento{ get; set; }     
        public static List<Avaliacao>? Musica{ get; set; }     
        public static List<Avaliacao>? Local{ get; set; }

        public static void CriarLista()
        {
            BebidasBar = new List<Avaliacao>() 
            {
                new Avaliacao("Bar de Coquitéis"),
                new Avaliacao("Refrigerantes"),
                new Avaliacao("Estação de vinhos espumantes"),
                new Avaliacao("Chopp e cervejas"),
            };
            Aperitivos = new List<Avaliacao>()
            {
                new Avaliacao("Torradas com patê"),
                new Avaliacao("Queijo mussarela cortado em cubos"),
                new Avaliacao("Enroladinhos de presunto"),
                new Avaliacao("Vinagrete"),
                new Avaliacao("Patê de presunto"),
            };
            Sobremesa = new List<Avaliacao>()
            {
                new Avaliacao("Mousse de maracujá"),
                new Avaliacao("Mousse de morango"),
                new Avaliacao("Mousse de chocolate"),
                new Avaliacao("Bolo de casamento (abacaxi cremoso)"),
                new Avaliacao("Sorvete artesanal"),
            };
            PratosPrincipais= new List<Avaliacao>()
            {
                new Avaliacao("Strogonoff de frango cremoso"),
                new Avaliacao("Arroz branco"),
                new Avaliacao("Arroz colorido"),
                new Avaliacao("Churrasco"),
            };
            Acompanhamento = new List<Avaliacao>()
            {
                new Avaliacao("Salada"),
                new Avaliacao("Batata-Frita"),
            };
            Musica = new List<Avaliacao>()
            {
                new Avaliacao("Como você avalia o DJ escolhido?"),
                new Avaliacao("Como você avalia a orquestra?"),
            };
            Local = new List<Avaliacao>()
            {
                new Avaliacao("Como você avalia o local da festa?"),
            };
        }
    }
}
