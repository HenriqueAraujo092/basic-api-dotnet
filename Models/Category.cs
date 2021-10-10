using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testeApi.Models {

    public class Category {

        public int Id { get; }

        [Required]
        public string Name { get; set; }
    }

}