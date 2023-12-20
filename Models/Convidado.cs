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
        public Color? CorStatus
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

        public FontImageSource IconeTipoConvidado
        {
            get
            {
           
                return TipoConvidado == TipoConvidado.VIP ?
                    new FontImageSource()
                    {
                        FontFamily = "FASolid",
                        Glyph = "\uf57b;",
                        Color = Colors.Orange
                    }
                    :
                    new FontImageSource()
                    {
                        FontFamily = "FASolid",
                        Glyph = "\uf500;",
                        Color = Colors.BlueViolet
                    }
                    ;
            }
        }
        public FontImageSource IconePresenca
        {
            get
            {

                return Presente ?
                    new FontImageSource()
                    {
                        FontFamily = "FASolid",
                        Glyph = "\uf00c;",
                        Color = Colors.Green
                    }
                    :
                    new FontImageSource()
                    {
                        FontFamily = "FASolid",
                        Glyph = "\uf00d;",
                        Color = Colors.Red
                    }
                    ;
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
