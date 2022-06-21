using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Party
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        [MaxLength(40)]
        public string PartyTitle { get; set; }

        [Required]
        [MaxLength(25)]
        public string Location { get; set; }

        [Required]
        public string Description { get; set; }

        public IEnumerable<Alcoholic> PartyMembers { get; set; }

        public IEnumerable<Alcohol> Drinks { get; set; }

        private Party()
        {

        }

        public Party(string partyTitle, string location, string description)
        {
            PartyTitle = partyTitle;
            Location = location;
            Description = description;
        }
    }
}