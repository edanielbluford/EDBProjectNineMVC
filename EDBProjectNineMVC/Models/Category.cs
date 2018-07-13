using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EDBProjectNineMVC.Models
{
    public class Category
    {
        
        public int CategoryID { get; set; }

        [DisplayName("Category")]
        public string CategoryType { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }

}