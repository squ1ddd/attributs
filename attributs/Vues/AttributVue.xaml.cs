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
		vueModele.Afficher();
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
        vueModele.UnAttribut.Add(new Attribut(nom.Text, type.Text, vis.Text,classe.Text));
		vis.Text = "";
		type.Text = "";
		nom.Text = "";
    }
}