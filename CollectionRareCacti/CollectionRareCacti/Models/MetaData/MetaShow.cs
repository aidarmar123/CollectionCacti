using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionRareCacti.Models.MetaData
{
    public partial class MetaShow
    {
        

        public int Id { get; set; }
        [Required]
        public System.DateTime Date { get; set; }
        [Required]
        public string Adress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowCacti> ShowCacti { get; set; }
    }
}
