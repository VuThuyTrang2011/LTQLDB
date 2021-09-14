using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLDB.Models
{
    [Table("Student")]
    public class Student
    {
      [Key]
        public string StudenID { get; set; }
        public string StudenName { get; set; }


    }
}