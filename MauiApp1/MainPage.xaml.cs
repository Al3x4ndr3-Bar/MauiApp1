namespace MauiApp1
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
                toto.TextColor = Colors.Green;
            }
            else
            {
                CounterBtn.Text = $"Clicked {count} times";
                toto.Text = count.ToString();
                toto.TextColor = Colors.Red;
                SemanticScreenReader.Announce(CounterBtn.Text);
            }
        }
    }
}