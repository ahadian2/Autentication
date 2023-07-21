using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Autentication.Models
{
    [Table("TUser")]
    public class Users
    {

        //***********************
        //UserID
        //***********************
        [Key]
        [Display(Name = "شماره کاربری")]
        public int UserID { get; set; }





        //***********************
        //Name
        //***********************
        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [MaxLength(50)]
        public string Name { get; set; }


        //***********************
        //Family
        //***********************
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [MaxLength(50)]
        public string Family { get; set; }


        //***********************
        //Password
        //***********************
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [StringLength(13, MinimumLength = 5, ErrorMessage = "تعداد کاراکتر ها نباید کمتر از 5 و بیشتر از ۱3 باشد")]
        [DataType(DataType.Password)]
        [MaxLength(100)]
        public string Password { get; set; }


        //***********************
        //Email
        //***********************
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [EmailAddress(ErrorMessage = "قالب {0} اشتباه است")]
        [MaxLength(100)]
        public string Email { get; set; }


        //***********************
        //MobileNumber
        //***********************
        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [RegularExpression("09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}", ErrorMessage = "قالب {0} اشتباه است")]
        [MaxLength(13)]
        public string MobileNumber { get; set; }





        //***********************
        //IsActive
        //***********************
        [Display(Name = "فعال / غیر فعال")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        public bool IsActive { get; set; }


        //***********************
        //RegisterDate
        //***********************
        [Display(Name = "تاریخ ثبت نام")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [DisplayFormat(DataFormatString = "{0: dddd, dd MMMM yyyy}")]
        public DateTime RegisterDate { get; set; }
    }
}