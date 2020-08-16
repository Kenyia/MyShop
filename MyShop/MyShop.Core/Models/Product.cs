using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I would change the variables and product Category because it's confusing because you have it more than one class. I think they are the same objects so you could make one class the base class
//(Parent) and the other class a child the child can use fields (objects) from parent but parent can't take from child.


namespace MyShop.Core.Models
{
    public class Product : BaseEntity
    {
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

    }
}
