using System.ComponentModel.DataAnnotations;

namespace FirstCore.MyModel
{
    public class Customer
    {
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Name { get; set; }
    }
}