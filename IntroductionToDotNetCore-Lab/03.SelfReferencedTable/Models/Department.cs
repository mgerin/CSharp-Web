namespace _03.SelfReferencedTable.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class Department
    {
        public Department()
        {
            this.Employees = new List<Employee>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
