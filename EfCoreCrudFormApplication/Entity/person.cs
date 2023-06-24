using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreCrudFormApplication.Entity
{
    public class Person
    {
        [Key]
        
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string PersonLastName { get; set; }
        //deneme
    }
}
