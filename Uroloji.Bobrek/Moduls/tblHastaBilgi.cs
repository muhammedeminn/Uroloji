using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class tblHastaBilgi
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Hadi { get; set; }
        [StringLength(50)]
        public string Sadi { get; set; }
        [StringLength(20)]
        public string ProtNo { get; set; }
        public DateTime OpTarih { get; set; }
        [StringLength(150)]
        public string OpTur { get; set; }
        public int Takip { get; set; }
        public int Anah { get; set; }

    }
}
