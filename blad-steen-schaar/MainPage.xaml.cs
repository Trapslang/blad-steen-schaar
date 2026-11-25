namespace blad_steen_schaar
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"klik {count} keer";
            else
                CounterBtn.Text = $"klik {count} keer";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
