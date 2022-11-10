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
        
        #endregion

        #region Constructor
        public Attribut(string nonAttribut, string type,string visibilite)
        {
            NonAttribut = nonAttribut;
            Type = type;
            Visibilite = visibilite;
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
        #endregion

        #region Methods
        public string GetAttribute()
        {
            return _visibilite+" "+_type+" _"+_nonAttribut+";";
        }
        public string GetGettersSetters()
        {
            if (!_visibilite.Equals("public"))
            {
                string param = _nonAttribut.First().ToString().ToUpper();
                string res = param.ToString()+_nonAttribut.Substring(1,_nonAttribut.Length-1);
                return "public " + _type + " " + res+
                    " {"+
                    " get { return "+_nonAttribut+"; } "+
                    " set { "+_nonAttribut+" = value; } "+
                    " }"
                    ;
            }
            else
            {
                return "";
            }
        }
        #endregion
    }
}
