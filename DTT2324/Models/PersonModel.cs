using System.ComponentModel.DataAnnotations;

namespace DTT2324.Models
{
    public class Person
    {
        [Key]
        public string HoTen{get;set;}
        public int PersonID{get;set;}
        public int Age {get;set;}

    }
}


