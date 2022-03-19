using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApp.Data
{
    public class CounterClass
    {
        [Key]
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string Counter { get; set; }
        public string Length { get; set; }
    }
}
