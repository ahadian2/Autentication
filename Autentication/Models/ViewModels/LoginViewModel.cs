using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Autentication.Models.ViewModels
{
    public class LoginViewModel
    {

        //***********************
        //Email
        //***********************
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [EmailAddress(ErrorMessage = "قالب {0} اشتباه است")]
        [MaxLength(100)]
        public string Email { get; set; }

        //***********************
        //Password
        //***********************
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [StringLength(13, MinimumLength = 5, ErrorMessage = "تعداد کاراکتر ها نباید کمتر از 5 و بیشتر از ۱3 باشد")]
        [DataType(DataType.Password)]
        [MaxLength(100)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }



    }
}