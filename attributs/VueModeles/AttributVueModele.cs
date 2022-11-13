
using attributs.Modeles;
using ENCHERE_SIO.VuesModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributs.VueModeles
{
    public class AttributVueModele:BaseVueModele
    {
        #region Attributes
        List<Attribut> _unAttribut;
        private string _attr = "";
        private string _getSet = "";
        private string _cla = "";

        #endregion

        #region Constructor
        public AttributVueModele()
        {
            _unAttribut = new List<Attribut>();
        }
        #endregion

        #region Getters/Setters
        public List<Attribut> UnAttribut
        {
            get { return _unAttribut; }
            set { SetProperty(ref _unAttribut, value); }
        }
        public string Attr
        {
            get { return _attr; }
            set { SetProperty(ref _attr, value); }
        }
        public string Cla
        {
            get { return _cla; }
            set { SetProperty(ref _cla, value); }
        }
        public string GetSet
        {
            get { return _getSet; }
            set { SetProperty(ref _getSet, value); }
        }

        #endregion

        #region Methods
        public void Afficher()
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            foreach (Attribut att in _unAttribut)
            {
                list.Add(att.GetAttribute());
                list2.Add(att.GetGettersSetters());
                Cla = att.GetClasse();
                //Affichage += att.GetAttribute() +" "+ att.GetGettersSetters(); 
            }
            foreach(string s in list)
            {
                Attr += s;
            }
            foreach(string s in list2)
            {
                GetSet += s;
            }

        }
        #endregion
    }
}
