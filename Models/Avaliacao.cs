using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casamento_conectado.Models
{

    public class Avaliacao
    {
        public string? Titulo { get; private set; }

        public Avaliacao(string? titulo)
        {
            Titulo = titulo;
        }
    }
}

