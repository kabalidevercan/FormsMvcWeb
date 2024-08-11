using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsMvcWeb.Models
{

    public class Product
    {

        [Display(Name = "Urun Id")]
        [BindNever]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Urun Adi")]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        public string Image { get; set; } = string.Empty;

        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        [Required]
        public int? CategoryId { get; set; }

    }

}