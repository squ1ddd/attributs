
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
        private string _affichage;
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
        public string Affichage
        {
            get { return _affichage; }
            set { SetProperty(ref _affichage, value); }
        }
        #endregion

        #region Methods
        public string Afficher()
        {
            foreach(Attribut att in _unAttribut)
            {
                Affichage += att.GetAttribute() + att.GetGettersSetters();
                
            }
            
            return Affichage;
        }
        #endregion
    }
}
