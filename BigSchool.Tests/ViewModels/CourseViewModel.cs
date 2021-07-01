using BigSchool.Tests.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BigSchool.Tests.ViewModels
{
    public class CourseViewModel
    {
        [Required(ErrorMessage = "Place không được để trống")]
        [Display(Name = "Place")]
        public string Place { get; set; }


        [Required(ErrorMessage = "Ngày không được để trống")]
        [Display(Name = "Ngày")]
        [FutureDate]
        public string Date { get; set; }

        [Required(ErrorMessage = "Thời gian không được để trống")]
        [Display(Name = "Thời gian")]
        [ValidTime]
        public string Time { get; set; }

        [Required(ErrorMessage = "Category không được để trống")]
        [Display(Name = "Category")]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}