namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navPage = new NavigationPage(new MainPage());

		navPage.BarBackground = Colors.Chocolate;
		navPage.BarTextColor= Colors.White;

		//MainPage = navPage; //Para mostrar MainPage

       // MainPage = new FlyoutPageDemo();//Para mostrar FlyoutPageDemo

		MainPage = new TabedPageDemo(); //Para mostrar TabbedPage (Pagina seccionada)

    }
}
