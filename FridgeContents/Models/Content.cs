using System;
using System.ComponentModel.DataAnnotations;

namespace FridgeContents.Models
{
    public class Content
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Content()
        {
            
        }

        internal int Max(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}