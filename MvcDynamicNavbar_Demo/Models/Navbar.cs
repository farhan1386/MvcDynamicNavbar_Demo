using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDynamicNavbar_Demo.Models
{
    public class Navbar
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter navar title")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter navar action name")]
        [StringLength(50)]
        [Display(Name ="Action Name")]
        public string ActionName { get; set; }

        [Required(ErrorMessage = "Please enter navar controller name")]
        [StringLength(50)]
        [Display(Name = "Controller Name")]
        public string ControllerName { get; set; }

        public DateTime Created { get; set; }

        public Navbar()
        {
            Created = DateTime.Now;
        }
        
    }
}