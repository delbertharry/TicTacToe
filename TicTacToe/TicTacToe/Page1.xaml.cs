using System;
using Xamarin.Forms;


namespace TicTacToe.Droid
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            Label label = new Label();
            label.Text = "Bienvini kay la.";
            this.Content = label;
        }
    }
}