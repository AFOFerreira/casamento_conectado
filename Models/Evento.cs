using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casamento_conectado.Models
{
    public enum StatusEvento
    {

        AGUARDANDO = 0,
        ANDAMENTO = 1,
        FINALIZADO = 2,
    }
    public class Evento
    {

        public string? Titulo { get; private set; }
        public StatusEvento Status { get; private set; }
        public string? Descricao { get; private set; }
        public ImageSource? Imagem { get; private set; }
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
                        :
                        return Colors.Black;
                }
            }
        }

        public Evento(string? titulo,  string? descricao, StatusEvento status, ImageSource? imagem)
        {
            Titulo = titulo;
            Status = status;
            Descricao = descricao;
            Imagem = imagem;
        }
    }
}
