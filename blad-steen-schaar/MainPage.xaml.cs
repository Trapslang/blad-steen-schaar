
namespace blad_steen_schaar;

public partial class MainPage : ContentPage
{
    string spelerKeuze = "";
    string botKeuze = "";

    Random random = new Random();

    public MainPage()
    {
        InitializeComponent();
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value == true)
        {
            RadioButton gekozen = (RadioButton)sender;

            spelerKeuze = gekozen.Content.ToString();

            if (spelerKeuze == "Blad")
            {
                speler.Source = "blad.png";
            }
            else if (spelerKeuze == "Steen")
            {
                speler.Source = "steen.png";
            }
            else if (spelerKeuze == "Schaar")
            {
                speler.Source = "schaar.png";
            }
        }
    }

    private void Speel_Clicked(object sender, EventArgs e)
    {
        if (spelerKeuze == "")
        {
            resultaat.Text = "Maak eerst een keuze!";
        }
        else
        {
            Controleer();
        }
    }

    private void Controleer()
    {
        int getal = random.Next(1, 4);

        if (getal == 1)
        {
            botKeuze = "Blad";
            botnetmove.Source = "blad.png";
        }
        else if (getal == 2)
        {
            botKeuze = "Steen";
            botnetmove.Source = "steen.png";
        }
        else
        {
            botKeuze = "Schaar";
            botnetmove.Source = "schaar.png";
        }

        if (spelerKeuze == botKeuze)
        {
            resultaat.Text = "Gelijkspel!";
        }
        else if ((spelerKeuze == "Blad" && botKeuze == "Steen") ||
                 (spelerKeuze == "Steen" && botKeuze == "Schaar") ||
                 (spelerKeuze == "Schaar" && botKeuze == "Blad"))
        {
            resultaat.Text = "Je hebt gewonnen!";
        }
        else
        {
            resultaat.Text = "Je hebt verloren!";
        }
    }
}
