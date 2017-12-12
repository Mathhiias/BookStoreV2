namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int BookId { get; set; }

        public int? AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int? NumOfPages { get; set; }

        public int YearPublished { get; set; }

        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual Author Author { get; set; }
    }
}
