using System.ComponentModel.DataAnnotations;

namespace frontback.Models
{
    public class Shipping
    {


        public int Id { get; set; }
        [MaxLength(50)]
       

        public string Tittle { get; set; }

        [MaxLength(100)]

        public string Description { get; set; }

        [MaxLength(100)]

        public string Image { get; set; }


    }
}
