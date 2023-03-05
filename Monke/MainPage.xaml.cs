using Monke.Models;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Monke;

public partial class MainPage : ContentPage
{
    public List<Monkey> monkeys { get; set; }
    public Monkey monkey { get => _monkey; set { if (value != _monkey) { _monkey = value; OnPropertyChanged("monkey"); } } }
    private Monkey _monkey { get; set; }
    int current = 0;
    public MainPage()
    {
        
        monkeys= new List<Monkey>();
        monkeys.Add(new Monkey
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
            Population = 10000
        });
        monkeys.Add(new Monkey
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg",
            Population = 23000
        });
        monkeys.Add(new Monkey
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg",
            Population = 12000
        });
        monkeys.Add(new Monkey
        {
            Name = "Squirrel Monkey",
            Location = "Central & South America",
            Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/saimiri.jpg",
            Population = 11000
        });
        monkey = monkeys[0];
        InitializeComponent();
        this.BindingContext = this;
    }
    private void ButtonEnabled()
    {
        if (current <= 0)
        {
            left_btn.IsEnabled = false;
            right_btn.IsEnabled = true;
        }
        else if (current >= monkeys.Count - 1)
        {
            right_btn.IsEnabled = false;
            left_btn.IsEnabled = true;
        }
        else
        {
            left_btn.IsEnabled = true;
            right_btn.IsEnabled = true;

        }

    }
    private void ChangePhoto(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        if (btn == right_btn)
            current = current + 1;
        if (btn == left_btn)
            current = current - 1;
        monkey= monkeys[current];
        ButtonEnabled();

    }
}

