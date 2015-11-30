namespace Epam.Training.Day14.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Records = new HashSet<Record>();
        }

        public int Id { get; set; }

        [Display(Name ="Имя")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Display(Name = "e-mail")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        [StringLength(30)]
        public string Email { get; set; }

        public int? UniversityId { get; set; }

        [Range(1, 5, ErrorMessage = "Недопустимое значение")]
        public int? Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Record> Records { get; set; }

        public virtual University University { get; set; }
    }
}
