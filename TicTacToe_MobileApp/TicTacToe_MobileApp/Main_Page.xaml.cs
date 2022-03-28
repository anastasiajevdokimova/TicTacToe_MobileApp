using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTacToe_MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main_Page : ContentPage
    {
        Button start_btn, bot_btn, symchange_btn;
        Label wel_lbl, lbl;
        Frame frame;
        Grid grid;
        public Main_Page()
        {
            wel_lbl = new Label
            {
                Text = "Welcome! Please, choose role and start the game! Enjoy! :)",
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                FontFamily = "Lobster",
                TextColor = Color.Purple
            };

            lbl = new Label
            {
                Text = "Tip: If You want play with bot - choose BOT MODE button, if You want play with friend on the same phone - choose START button.",
                FontSize = 10,
                TextColor = Color.MediumPurple
            };

            symchange_btn = new Button
            {
                Text = "Who plays?",
                BackgroundColor = Color.Yellow,
                CornerRadius = 90
            };
            //symchange_btn.Clicked += Pages_Change;

            bot_btn = new Button
            {
                Text = "Bot Mode!",
                BackgroundColor = Color.Yellow,
                CornerRadius = 90
            };
             
            start_btn = new Button
            {
                Text = "Start!",
                BackgroundColor = Color.Yellow,
                CornerRadius = 90
            };
            //start_btn.Clicked += Pages_Change;

            grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height = new GridLength(2, GridUnitType.Star)},
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star)},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)}
                }
            };

            grid.Children.Add(wel_lbl, 0, 1);
            grid.Children.Add(lbl, 0, 0);
            grid.Children.Add(symchange_btn, 1, 0);
            grid.Children.Add(start_btn, 0, 0);

            //frame = new Frame
            //{
            //    Content = grid,
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};

            StackLayout st = new StackLayout
            {
                Children = { wel_lbl, lbl, grid }
            };

            Content = st;

        }

        public async void Pages_Change(object sender, EventArgs e, bool result)
        {
            if (sender == symchange_btn)
            {
                //await Navigation.PushAsync(new PageName());
            }
            else if (sender == bot_btn)
            {
                await Navigation.PushAsync(new StartGameBot_Page());
            }
            else if (sender == start_btn)
            {
                //true = X, false = 0
                result = await DisplayAlert("Who plays first?","Choose:","X-Black","O-Red");
                await Navigation.PushAsync(new StartGameDouble_Page());
            }
        }
    }
}