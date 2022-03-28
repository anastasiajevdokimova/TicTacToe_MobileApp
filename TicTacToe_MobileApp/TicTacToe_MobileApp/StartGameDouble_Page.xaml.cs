using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static TicTacToe_MobileApp.Main_Page;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTacToe_MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartGameDouble_Page : ContentPage
    {
        Grid grid;
        Frame frame;
        BoxView b1, b2, b3, b4, b5, b6, b7, b8, b9;
       // static int[] arr;

        public StartGameDouble_Page()
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++ )
            //    {
            //        arr[i, j] = 0;
            //    }
            //}


            //строим сетку
            Grid grid = new Grid();
            {
                for (int i = 0; i < 3; i++)
                {
                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                }
            }
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            b1 = new BoxView { Color = Color.WhiteSmoke };
            b1.GestureRecognizers.Add(tap);

            b2 = new BoxView { Color = Color.WhiteSmoke };
            b2.GestureRecognizers.Add(tap);

            b3 = new BoxView { Color = Color.WhiteSmoke };
            b3.GestureRecognizers.Add(tap);

            b4 = new BoxView { Color = Color.WhiteSmoke };
            b4.GestureRecognizers.Add(tap);

            b5 = new BoxView { Color = Color.WhiteSmoke };
            b5.GestureRecognizers.Add(tap);

            b6 = new BoxView { Color = Color.WhiteSmoke };
            b6.GestureRecognizers.Add(tap);

            b7 = new BoxView { Color = Color.WhiteSmoke };
            b7.GestureRecognizers.Add(tap);

            b8 = new BoxView { Color = Color.WhiteSmoke };
            b8.GestureRecognizers.Add(tap);

            b9 = new BoxView { Color = Color.WhiteSmoke };
            b9.GestureRecognizers.Add(tap);

            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        b = new BoxView { Color = Color.WhiteSmoke };
            //        grid.Children.Add(b, c, r);
            //        TapGestureRecognizer tap = new TapGestureRecognizer();
            //        tap.Tapped += Tap_Tapped;
            //        b.GestureRecognizers.Add(tap);
            //    }
            //}

            frame = new Frame
            {
                Content = grid,
                HeightRequest = 560,
                WidthRequest = 560
            };
            StackLayout st = new StackLayout
            {
                Children = { frame }
            };

            Content = st;
            
        }

        public void WinCheck()
        {
            //check if X (black) win

            // 1, 2, 3 - первый ряд по горизонтали
            if (b1.Color == Color.Black && b2.Color == Color.Black && b3.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }
            // 4, 5, 6 - второй ряд по горизонтали
            else if (b4.Color == Color.Black && b5.Color == Color.Black && b6.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }
            // 7, 8, 9 - третий ряд по горизонтали
            else if (b7.Color == Color.Black && b8.Color == Color.Black && b9.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }
            //1, 4, 7 - первый ряд по вертикали
            else if (b1.Color == Color.Black && b4.Color == Color.Black && b7.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }
            //2, 5, 8 - второй ряд по вертикали
            else if (b2.Color == Color.Black && b5.Color == Color.Black && b8.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }
            //3, 6, 9 - третий ряд по вертикали
            else if (b3.Color == Color.Black && b6.Color == Color.Black && b9.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }
            //1, 5, 9 - по диагонали
            else if (b1.Color == Color.Black && b5.Color == Color.Black && b9.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }
            //3, 5, 7 - по диагонали
            else if (b3.Color == Color.Black && b5.Color == Color.Black && b7.Color == Color.Black)
            {
                DisplayAlert("!", "x win!!!", "OK");
            }

            //check if 0 (red) win

            // 1, 2, 3 - первый ряд по горизонтали
            if (b1.Color == Color.Red && b2.Color == Color.Red && b3.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
            // 4, 5, 6 - второй ряд по горизонтали
            else if (b4.Color == Color.Red && b5.Color == Color.Red && b6.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
            // 7, 8, 9 - третий ряд по горизонтали
            else if (b7.Color == Color.Red && b8.Color == Color.Red && b9.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
            //1, 4, 7 - первый ряд по вертикали
            else if (b1.Color == Color.Red && b4.Color == Color.Red && b7.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
            //2, 5, 8 - второй ряд по вертикали
            else if (b2.Color == Color.Red && b5.Color == Color.Red && b8.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
            //3, 6, 9 - третий ряд по вертикали
            else if (b3.Color == Color.Red && b6.Color == Color.Red && b9.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
            //1, 5, 9 - по диагонали
            else if (b1.Color == Color.Red && b5.Color == Color.Red && b9.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
            //3, 5, 7 - по диагонали
            else if (b3.Color == Color.Red && b5.Color == Color.Red && b7.Color == Color.Red)
            {
                DisplayAlert("!", "o win!!!", "OK");
            }
        }

        public async void Tap_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Who plays first?", "Choose:", null, "x", "o");
            //var box = BoxView
            var b = (BoxView)sender;
            var r = Grid.GetRow(b); //определяем координату 
            var c = Grid.GetColumn(b);

            if (result == "x")
            {
                b.Color = Color.Black;
                //arr[r, c] = 1;
            }
            else if (result == "o")
            {
                b.Color = Color.Red;
                //arr[r, c] = 2;
            }

        }

    }
}