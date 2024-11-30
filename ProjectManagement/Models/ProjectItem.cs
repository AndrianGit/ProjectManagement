using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace ProjectManagement.Models
{
    public class ProjectItem
    {
        

        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public string ProjectDescription { get; set; }
       
    }
}