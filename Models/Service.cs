using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VariciDanismanlikMVC.Models
{
    public class Service
    {
           public int Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Action { get; set; }
    }
}