using Xamarin.Forms;

namespace SharedResourceDictionary
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent ();

			MainPage = new MyPage ();
		}
	}
}