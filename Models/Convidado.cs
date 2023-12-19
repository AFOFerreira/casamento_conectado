using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace casamento_conectado.Models
{
    public enum TipoConvidado
    {
        VIP,
        NORMAL
    }
    public class Convidado
    {
        public int Id { get; private set; }
        public string? Nome { get; private set; }
        public TipoConvidado TipoConvidado { get; private set; }
        public bool Presente { get; private set; }
        public Color? Color
        {
            get
            {
                if (!Presente)
                {
                    return Colors.Red;
                }
                else
                {
                    return TipoConvidado == TipoConvidado.VIP ? Colors.Orange : Colors.Green;
                }
            }
        }

        public Convidado(int id, string? nome, TipoConvidado tipoConvidado, bool presente)
        {
            Id = id;
            Nome = nome;
            TipoConvidado = tipoConvidado;
            Presente = presente;
        }
    }
}
