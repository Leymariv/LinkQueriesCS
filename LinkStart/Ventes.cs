//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqWinformProject.LinkStart
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventes
    {
        public int Id { get; set; }
        public int couleurid { get; set; }
        public int marqueid { get; set; }
        public double valeur { get; set; }
        public System.DateTime date { get; set; }

        public override bool Equals(object obj)
        {
            bool ret = true;
            var objCast = obj as Ventes;
            if (objCast == null)
            {
                ret = false;
            }
            else
            {
                ret = Equals(objCast.Id, Id) && Equals(objCast.date, date) && Equals(objCast.marqueid ,marqueid)
                    && Equals(objCast.couleurid, couleurid) && Equals(objCast.valeur, valeur);
            }
            return ret;
        }
    }
}
