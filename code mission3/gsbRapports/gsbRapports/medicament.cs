//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gsbRapports
{
    using System;
    using System.Collections.Generic;
    
    public partial class medicament
    {
        public medicament()
        {
            this.offrirs = new HashSet<offrir>();
        }
    
        public string id { get; set; }
        public string nomCommercial { get; set; }
        public string idFamille { get; set; }
        public string composition { get; set; }
        public string effets { get; set; }
        public string contreIndications { get; set; }
    
        public virtual famille famille { get; set; }
        public virtual ICollection<offrir> offrirs { get; set; }
    }
}
