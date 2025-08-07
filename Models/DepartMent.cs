using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_FreamWork.Models
{
    [Table("Department", Schema = "dbo")]
    public class DepartMent
    {
        [Key ] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display (Name  = "DepartmentID")]

        public int DepartmentID { get; set; }
        [Required]

        [Column (TypeName ="nvarchar(150)")]
        [Display (Name ="departmentName")]

        public string DepartmentName { get; set; } = string.Empty;
       








    }
}
