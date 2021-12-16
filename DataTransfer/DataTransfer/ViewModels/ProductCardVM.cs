using DataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransfer.ViewModels
{
    public class ProductCardVM
    {
        public Product Product { get; set; }
        public List<Card> Cards { get; set; }
    }
}
