using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TPAzure.Models
{
    public class Advert
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImgPath { get; set; }
    }
}