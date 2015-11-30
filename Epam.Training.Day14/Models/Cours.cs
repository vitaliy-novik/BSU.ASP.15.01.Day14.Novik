namespace Epam.Training.Day14.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Cours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cours()
        {
            Records = new HashSet<Record>();
        }

        public int Id { get; set; }

        [Display(Name = "��������")]
        [Required(ErrorMessage = "���� ������ ���� �����������")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "��������")]
        public string Description { get; set; }

        [Display(Name = "���� ������")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Record> Records { get; set; }
    }
}
