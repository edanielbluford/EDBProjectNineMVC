using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EDBProjectNineMVC.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        private DateTime reviewdate;

        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("Review")]
        public string Content { get; set; }

        [DisplayName("Review Date")]
        public DateTime ReviewDate
        {
            get { return this.reviewdate; }
            set { this.reviewdate = DateTime.Now; }
        }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }




    }
}