﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuan06_PhamVuLuan.Models
{
    public class Sach
    {
        //Hoàn thành
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
    }
}