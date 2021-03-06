﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Pocos
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
