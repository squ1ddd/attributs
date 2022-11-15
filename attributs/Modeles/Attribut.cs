using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributs.Modeles
{
    public class Attribut
    {
        #region Attributes
        private string _nonAttribut;
        private string _type;
        private string _visibilite;
        private string _classe;
        private Boolean _comboGet;
        private Boolean _comboSet;
        public static List<int> Compteur = new List<int>();
        int valeur;
        string indentation = "        ";
        #endregion

        #region Constructor
        public Attribut(string nonAttribut, string type,string visibilite,string cla, Boolean CBget, Boolean CBset)
        {
            NonAttribut = nonAttribut;
            Type = type;
            Visibilite = visibilite;
            Classe  = cla;
            this.Soustraire();
            Compteur.Add(valeur);
            ComboGet = CBget;
            ComboSet = CBset;
        }
        #endregion

        #region Getters/Setters
        public string NonAttribut
        {
            get { return _nonAttribut; }
            set { _nonAttribut = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Visibilite
        {
            get { return _visibilite; }
            set { _visibilite = value; }
        }
        public string Classe
        {
            get { return _classe; }
            set { _classe = value; }
        }
        public Boolean ComboGet
        {
            get { return _comboGet; }
            set { _comboGet = value; }
        }
        public Boolean ComboSet
        {
            get { return _comboSet; }
            set { _comboSet = value; }
        }
        #endregion

        #region Methods
        public string GetAttribute()
        {
            if (!_visibilite.Equals("public"))
            {
                return indentation+" " + _visibilite + " " + _type + " " + " _" + _nonAttribut + "; \n";
            }
            else
            {
                string param = _nonAttribut.First().ToString().ToUpper();
                string res = param.ToString() + _nonAttribut.Substring(1, _nonAttribut.Length - 1);
                return indentation+" " + _visibilite + " " + _type + " " + res + "; \n";
            }
        }
        public void Soustraire()
        {
            if (Compteur.Count == 0)
            {
                valeur = 0;
            }
            else
            {
                valeur = Compteur[Compteur[Compteur.Count - 1]] + 1;
            }
        }
        public string GetGettersSetters(string getters,string setters)
        {
            if (!_visibilite.Equals("public"))
            {
                string param = _nonAttribut.First().ToString().ToUpper();
                string res = param.ToString()+_nonAttribut.Substring(1,_nonAttribut.Length-1);
                return indentation+" "+"public " + _type + " " + res+ "\n"+
                    indentation+" " + " {\n" +
                    getters+
                    setters+
                    indentation+" " + " } \n"
                    ;
            }
            else
            {
                return "";
            }
        }
        public string GetGetters()
        {
            return indentation + " " + "        get { return _" + _nonAttribut + "; } \n";
        }
        public string GetSetters()
        {
            return indentation + " " + "        set { _" + _nonAttribut + " = value; } \n";  
        }
        public string GetClasse()
        {
            return " " + "public class" + _classe + " \n" + " " + " { ";
        }
        public string GetConstructeur(string param,string param2)
        {
            return indentation + " " + " public " + _classe + " " + " ("+param+")\n " + indentation+" {\n" +param2+ " " +indentation+ " }";
        }
        //donne le paramètre du constructeur
        public string GetParam()
        {
            int index=0;
            Compteur.Reverse();
            foreach(int i in Compteur)
            {
                index = i;
            }
            string virgule;
            if(Compteur.Count == 1)
            {
                virgule = " ";
            }
            else
            {
                virgule = ", ";
            }
            if (_type.Contains("List"))
            {
                return "";
            }
            else
            {
                return " " + _type + " param" + index + virgule;
            }
        }
        //attribue les valeurs dans le constructeur
        public string GetParam2()
        {
            string res="";
            if (!_visibilite.Equals("public"))
            {
                res = "        _" + _nonAttribut;
            }
            else
            {
                string param = _nonAttribut.First().ToString().ToUpper();
                res = "        "+param.ToString() + _nonAttribut.Substring(1, _nonAttribut.Length - 1);
            }
            int index =0;
            foreach(int i in Compteur)
            {
                index = i;
            }
            Compteur.Remove(index);
            Compteur.Reverse();
            if (_type.Contains("List"))
            {
                return indentation +indentation+"_" + _nonAttribut + " = new " + _type + " ();\n";
            }
            else
            {
                return indentation + res + " =" + " param" + index + ";\n";
            }
        }
        #endregion
    }
}
