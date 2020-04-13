using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Hw6
{
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();
			List<Page> listOfPages = new List<Page> () {
				new AbsoluteLayout (),
				new RelativeLayout (),
				new StackLayout ()
			};

			listPages.ItemsSource = listOfPages;
			listPages.ItemSelected += ListPages_ItemSelected;
		}

		void ListPages_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null) {
				this.Navigation.PushAsync ((Page)e.SelectedItem);
			}
			listPages.SelectedItem = null;
		}
	}
}