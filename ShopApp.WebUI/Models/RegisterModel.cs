using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class RegisterModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /*
        
        [Required(ErrorMessage = "isim belirtiniz")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "kullanıcı adı belirtiniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "parola belirtiniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "parolayı tekrar giriniz belirtiniz")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "e-mail adresi belirtiniz")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        */
    }
}
