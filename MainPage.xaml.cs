namespace MauiApp2_HACB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                CounterBtn.Text = $"Clicked {count} time";
                contador.Text = $"Clicked {count} time";
            }
            else
            {
                CounterBtn.Text = $"Clicked {count} times";
                contador.Text = $"Clicked {count} times";
            }
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void ir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }

        private void CalculadoraIMC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculadoraIMC());
        }
    }

}
