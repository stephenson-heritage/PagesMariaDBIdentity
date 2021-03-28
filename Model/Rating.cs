
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PagesMariaDB.Models
{

    public class Rating
    {
        public uint RatingID { get; set; }

        public uint Score { get; set; }

        public string Comment { get; set; }

        public virtual Product Product { get; set; }
    }

}