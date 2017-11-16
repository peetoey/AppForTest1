using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppForTest1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();

            viewButton.Clicked += ViewButton_Clicked;
            stackButton.Clicked += StackButton_Clicked;
            absoluteButton.Clicked += AbsoluteButton_Clicked;
            gridButton.Clicked += GridButton_Clicked;
            contentButton.Clicked += ContentButton_Clicked;
            navigationButton.Clicked += NavigationButton_Clicked;
            tabbedButton.Clicked += TabbedButton_Clicked;
            carouselButton.Clicked += CarouselButton_Clicked;
		}

        private void CarouselButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var cp = new CarouselPage();
            cp.Children.Add(new TabbedPage1());
            cp.Children.Add(new TabbedPage2());
            cp.Children.Add(new TabbedPage3());
            var np = new NavigationPage(cp);
            mp.Detail = np;
            mp.IsPresented = false;
        }

        private void TabbedButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new TabbedPage1());
            tp.Children.Add(new TabbedPage2());
            tp.Children.Add(new TabbedPage3());
            var np = new NavigationPage(tp);
            mp.Detail = np;
            mp.IsPresented = false;


        }

        private void NavigationButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            mp.Detail = new NavigationPage(new NavPage1());
            mp.IsPresented = false;
        }

        private void ContentButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            mp.Detail = new NavigationPage(new MyPage1());
            mp.IsPresented = false;
        }

        private void GridButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            mp.Detail = new NavigationPage(new GridPage());
            mp.IsPresented = false;
        }

        private void AbsoluteButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            mp.Detail = new NavigationPage(new AbsolutePage());
            mp.IsPresented = false;
        }

        private void StackButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            mp.Detail = new NavigationPage(new StackPage());
            mp.IsPresented = false;
        }

        private void ViewButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            mp.Detail = new NavigationPage(new MainPage());
            mp.IsPresented = false;
                         
        }
    }
}