using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casamento_conectado.Models
{
    public class Foto
    {
        public string? Descricao { get; private set; }
        public ImageSource? Imagem { get; private set; }

        public Foto( ImageSource? imagem, string? descricao)
        {
            Imagem = imagem;
            Descricao = descricao;
        }
    }
}
