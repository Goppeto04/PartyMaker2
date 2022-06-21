using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Alcohol
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        [MaxLength(40)]
        public string Title { get; set; }

        [Required]
        [MaxLength(20)]
        public string MainIngrediant { get; set; }

        [Required]
        [MaxLength(25)]
        public string Countries { get; set; }

        public double PriceInBushido { get; set; }
        public double PriceInOnyx { get; set; }
        public double PriceInSecrets { get; set; }

        private Alcohol()
        {

        }

        public Alcohol(string title, string mainIngrediant, string countries)
        {
            Title = title;
            MainIngrediant = mainIngrediant;
            Countries = countries;
        }
    }
}