
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
        private string _const = "";
        private string _getters = "";
        private string _setters = "";

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
        public string Const
        {
            get { return _const; }
            set { SetProperty(ref _const, value); }
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
        public string Getters
        {
            get { return _getters; }
            set { SetProperty(ref _getters, value); }
        }
        public string Setters
        {
            get { return _setters; }
            set { SetProperty(ref _setters, value); }
        }

        #endregion

        #region Methods
        public void Afficher()
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            string param = "";
            string param2 = "";
            foreach (Attribut att in _unAttribut)
            {
                if (att.ComboGet is true)
                {
                    Getters = att.GetGetters();
                }
                else
                {
                    Getters = "";
                }
                if (att.ComboSet is true)
                {
                    Setters = att.GetSetters();
                }
                else
                {
                    Setters = "";
                }
                if(att.ComboGet is false && att.ComboSet is false)
                {

                }
                else
                {
                    list2.Add(att.GetGettersSetters(Getters, Setters));
                }
                list.Add(att.GetAttribute());
                Cla = att.GetClasse();
                param += att.GetParam();
                param2 += att.GetParam2();
                Const = att.GetConstructeur(param,param2);
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
        public void Telechargement(string param)
        {
            StreamWriter sw = new StreamWriter("Téléchargements");
            sw.WriteLine(param);
            sw.Close();
        }
        #endregion
    }
}
