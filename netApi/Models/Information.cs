using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace netApi.Models
{
    public partial class Information
    {
        [Key]
        public int InfoId { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Info { get; set; }
    }
}
