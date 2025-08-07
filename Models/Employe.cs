using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_FreamWork.Models
{
    [Table("Employees", Schema = "dbo")]
    public class Employes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Employee ID")]
        public int Employee_Id { get; set; }

        [Required(ErrorMessage = "Employee number is required")]
        [Column(TypeName = "nvarchar(150)")]
        [Display(Name = "Employee Number")]
        public string Employee_Number { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee name is required")]
        [Display(Name = "Employee Name")]
        [Column(TypeName = "nvarchar(150)")]
        public string Employee_Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DOB { get; set; } = DateTime.Today.AddYears(-25);

        [Required(ErrorMessage = "Hiring date is required")]
        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Hiriring_Date { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Net salary is required")]
        [Display(Name = "Net Salary")]
        [Column(TypeName = "decimal(12,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be greater than zero")]
        public decimal NetSalary { get; set; }

        [Required(ErrorMessage = "Gross salary is required")]
        [Display(Name = "Gross Salary")]
        [Column(TypeName = "decimal(12,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be greater than zero")]
        public decimal Gross_Salary { get; set; } = 0;

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual DepartMent DepartMent { get; set; }
    }
}
