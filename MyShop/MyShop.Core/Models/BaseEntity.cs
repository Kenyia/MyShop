using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{

//I think you need a IEnumrable on this class since it is your base class every other class should inherit from it. You also don't need parse the BaseEntity as abstract because
//your using IENUMERABLE with that tag you don't have to define a class a certain way to get it to act a certain way, but you have to define an abstract class can only act the 
//way it's define it too inherent from child classes  
//  public class BaseEntity

    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public BaseEntity() {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.Now;
        }
    }
}
