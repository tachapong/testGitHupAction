using System.Diagnostics;
using System.Linq;

namespace uiPin;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        one.Clicked += btnClick;
        Two.Clicked += btnClick;
        three.Clicked += btnClick;
        four.Clicked += btnClick;
        five.Clicked += btnClick;
        six.Clicked += btnClick;
        seven.Clicked += btnClick;
        eight.Clicked += btnClick;
        nine.Clicked += btnClick;
        zz.Clicked += btnClick;
        f.Clicked += btnnClick;
        d.Clicked += btnnClick;
    }

    public void btnClick(object sender, EventArgs e)
    {
        Debug.WriteLine("uuuuuuuu", aa.Text);
        if (aa.Text.Length <= 5)
        {
            var btn = sender as Button;
            aa.Text += btn.Text;

            // Image
            //bb.Source = "humidityhigh.png";

            //StackLayout
            if (aa.Text.Length == 1)
            {
                (bb.Children[0] as Image).Source = "humidityhigh.png";
            }
            if (aa.Text.Length == 2)
            {
                (bb.Children[1] as Image).Source = "humidityhigh.png";
            }
            if (aa.Text.Length == 3)
            {
                (bb.Children[2] as Image).Source = "humidityhigh.png";
            }
            if (aa.Text.Length == 4)
            {
                (bb.Children[3] as Image).Source = "humidityhigh.png";
            }
            if (aa.Text.Length == 5)
            {
                (bb.Children[4] as Image).Source = "humidityhigh.png";
            }
            if (aa.Text.Length == 6)
            {
                (bb.Children[5] as Image).Source = "humidityhigh.png";
            }
        }
    }

    public void btnnClick(object sender, EventArgs e)
    {
        var btn = sender as Button;
        if (btn.Text == "ลืม pin")
        {
            DisplayAlert("", btn.Text, "ok");
        }

        else if (btn.Text == "ลบ")
        {
            aa.Text = aa.Text.Substring(0, aa.Text.Length - 1);
            //DisplayAlert("", x, aa.Text, "ok");

            if (aa.Text.Length == 0)
            {
                (bb.Children[0] as Image).Source = "humiditylow.png";
            }
            if (aa.Text.Length == 1)
            {
                (bb.Children[1] as Image).Source = "humiditylow.png";
            }
            if (aa.Text.Length == 2)
            {
                (bb.Children[2] as Image).Source = "humiditylow.png";
            }
            if (aa.Text.Length == 3)
            {
                (bb.Children[3] as Image).Source = "humiditylow.png";
            }
            if (aa.Text.Length == 4)
            {
                (bb.Children[4] as Image).Source = "humiditylow.png";
            }
            if (aa.Text.Length == 5)
            {
                (bb.Children[5] as Image).Source = "humiditylow.png";
            }
        }
    }

}

