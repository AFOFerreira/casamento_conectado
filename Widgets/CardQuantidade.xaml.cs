using CommunityToolkit.Maui.Views;

namespace casamento_conectado.Widgets;

public partial class CardQuantidade : Border
{
    public static readonly BindableProperty TituloProperty =
    BindableProperty.Create("Titulo", typeof(string), typeof(CardQuantidade), string.Empty);

    public string Titulo
    {
        get => (string)GetValue(TituloProperty);
        set => SetValue(TituloProperty, value);
    }

    public static readonly BindableProperty QuantidadeProperty =
    BindableProperty.Create("Quantidade", typeof(string), typeof(CardQuantidade), string.Empty);

    public string Quantidade
    {
        get => (string)GetValue(QuantidadeProperty);
        set => SetValue(QuantidadeProperty, value);
    }
    
    public static readonly BindableProperty ColorTituloProperty =
    BindableProperty.Create("ColorTitulo", typeof(Color), typeof(CardQuantidade), Colors.Black);

    public Color ColorTitulo
    {
        get => (Color)GetValue(ColorTituloProperty);
        set => SetValue(ColorTituloProperty, value);
    } 
    
    public static readonly BindableProperty ColorValueProperty =
    BindableProperty.Create("ColorValue", typeof(Color), typeof(CardQuantidade), Colors.Black);

    public Color ColorValue
    {
        get => (Color)GetValue(ColorValueProperty);
        set => SetValue(ColorValueProperty, value);
    }

    public CardQuantidade()
    {
        InitializeComponent();
    }
}