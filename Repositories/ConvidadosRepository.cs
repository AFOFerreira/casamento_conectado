using casamento_conectado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casamento_conectado.Repositories
{
    public static class ConvidadosRepository
    {
        public static List<Convidado>? Convidados { get; private set; }
        public static void CriarLista()
        {
            Convidados = new List<Convidado>()
            {
                new Convidado(0,"Sofia Oliveira",TipoConvidado.NORMAL,true ),
                new Convidado(1,"Pedro Santos",TipoConvidado.VIP,true ),
                new Convidado(2,"Marina Costa",TipoConvidado.VIP,true ),
                new Convidado(3,"Lucas Pereira",TipoConvidado.NORMAL,false ),
                new Convidado(4,"Isabella Lima",TipoConvidado.NORMAL,true ),
                new Convidado(5,"Matheus Silva",TipoConvidado.VIP,true ),
                new Convidado(6,"Laura Martins",TipoConvidado.NORMAL,true ),
                new Convidado(7,"Lucas Pereira",TipoConvidado.VIP,true ),
                new Convidado(8,"Isabella Lima",TipoConvidado.NORMAL,false ),
                new Convidado(9,"Matheus Silva",TipoConvidado.VIP,true ),
                new Convidado(10,"Laura Martins",TipoConvidado.NORMAL,true ),
                new Convidado(11,"Isabella Lima",TipoConvidado.NORMAL,true ),
                new Convidado(12,"Matheus Silva",TipoConvidado.VIP,true ),
                new Convidado(13,"Laura Martins",TipoConvidado.NORMAL,true ),
                new Convidado(14,"Lucas Pereira",TipoConvidado.NORMAL,false ),
                new Convidado(15,"Isabella Lima",TipoConvidado.NORMAL,true ),
                new Convidado(16,"Lucas Pereira",TipoConvidado.NORMAL,true ),
                new Convidado(17,"Isabella Lima",TipoConvidado.NORMAL,true ),
            };
        }
    }
}
