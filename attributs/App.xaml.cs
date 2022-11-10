using attributs.Vues;

namespace attributs;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AttributVue();
	}
}
