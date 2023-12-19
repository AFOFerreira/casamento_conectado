using casamento_conectado.Models;

namespace casamento_conectado.Repositories
{
    public static class FotosRepository
    {
        public static List<Foto>? Fotos { get; private set; }
        public static void CriarLista()
        {
            Fotos = new List<Foto>() 
            {
                new Foto(ImageSource.FromFile("foto01.svg"), "Vocês dois irradiam felicidade! Que jornada incrível vocês estão começando juntos."),
                new Foto(ImageSource.FromFile("foto02.svg"), "A beleza desse momento é indescritível. Parabéns pelo casamento dos sonhos!"),
                new Foto(ImageSource.FromFile("foto03.svg"), "Que casamento maravilhoso! Cada detalhe reflete amor e cuidado."),
                new Foto(ImageSource.FromFile("foto04.svg"), "Celebrando o amor e a união, um instante que ficará eternamente em nossos corações."),
                new Foto(ImageSource.FromFile("foto05.svg"), "A apresentação desta comida é tão bonita que parece uma obra de arte comestível."),
                new Foto(ImageSource.FromFile("foto06.svg"), "Parabéns ao chef por criar uma experiência culinária inesquecível. Cada garfada é uma jornada de prazer."),
                new Foto(ImageSource.FromFile("foto07.svg"), "Culinary perfection! Cada prato revela o cuidado e a maestria do chef. Simplesmente delicioso!"),
                new Foto(ImageSource.FromFile("foto08.svg"), "Este local é simplesmente deslumbrante! A atmosfera encantadora adicionou um toque mágico à celebração."),
                new Foto(ImageSource.FromFile("foto09.svg"), "Essa foto captura perfeitamente a alegria e a emoção do dia. Lindo demais!"),
              
            };
        }
    }
}
