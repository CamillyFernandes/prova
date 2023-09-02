namespace DiceRoller;
using System;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    private void RolaroDado(object sender, EventArgs e)
    {
        Random random = new Random();
        resultado.Text = Convert.ToString (random.Next(1, 7));
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);


       
    }
}

