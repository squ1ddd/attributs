namespace attributs.Vues;
using attributs.VueModeles;
using attributs.Modeles;

public partial class AttributVue : ContentPage
{
	AttributVueModele vueModele;
	public AttributVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new AttributVueModele();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        if ((vis.Text !="") && (type.Text !="") && (nom.Text !=""))
		{
			resteAttributs.IsVisible = true;
        }
		else
		{
            vueModele.Afficher();
        }
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
        resteAttributs.IsVisible = false;
        if ((vis.Text is not null) && (type.Text is not null) && (nom.Text is not null) && (classe.Text is not null))
		{
            vueModele.UnAttribut.Add(new Attribut(nom.Text, type.Text, vis.Text, classe.Text, gettersCheckBox.IsChecked, settersCheckBox.IsChecked));
			valeurNulle.IsVisible = false;
        }
		else
		{
			valeurNulle.IsVisible = true;
		}

        vis.Text = "";
		type.Text = "";
		nom.Text = "";
		gettersCheckBox.IsChecked = false;
		settersCheckBox.IsChecked=false;
		
    }

	private void Button_Clicked_2(object sender, EventArgs e)
	{

	}
}