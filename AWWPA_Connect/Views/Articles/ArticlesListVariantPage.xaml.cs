using System;
using Xamarin.Forms;

namespace AWWPA_Connect
{
	public partial class ArticlesListVariantPage : ContentPage
	{
		public ArticlesListVariantPage ()
		{
			InitializeComponent ();

			BindingContext = new PostsViewModel ();
		}

		private async void OnItemTapped(Object sender, EventArgs e)
		{
			var selectedItem = ((ListView)sender).SelectedItem;
			var post = (Post) selectedItem;
			var articleView = new ArticleViewPage(new ArticleViewModel(post.Id));

			await Navigation.PushAsync( articleView );
		}
	}
}

