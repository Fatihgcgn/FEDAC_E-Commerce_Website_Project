// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Threading.Tasks;

// namespace FEDAC.webui.Models
// {
//     public class Product
//     {
//         public int ProductId { get; set; }
        
//         [Required]
//         [StringLength(60,MinimumLength = 5,ErrorMessage ="Ürün ismi 5-60 karakter arasında olmalıdır!")]
//         public string Name { get; set; }

//         [Required(ErrorMessage ="Fiyat değeri girmek zorundasınız!")]
//         [Range(1,100000)]
//         public double? Price { get; set; }
//         public string Description { get; set; }

//         [Required]
//         public string ImageUrl { get; set; }
//         public bool IsApproved { get; set; }
//         [Required]
//         public int? CategoryId { get; set; }
//     }
// }