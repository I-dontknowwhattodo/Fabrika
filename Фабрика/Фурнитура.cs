namespace Фабрика
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Фурнитура()
        {
            Склад_фурнитуры = new HashSet<Склад_фурнитуры>();
            Фурнитура_изделия = new HashSet<Фурнитура_изделия>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(100)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Ширина { get; set; }

        [StringLength(50)]
        public string Длина { get; set; }

        [Required]
        [StringLength(50)]
        public string Тип { get; set; }

        [Required]
        [StringLength(50)]
        public string Цена { get; set; }

        [Required]
        [StringLength(50)]
        public string Вес { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад_фурнитуры> Склад_фурнитуры { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Фурнитура_изделия> Фурнитура_изделия { get; set; }
    }
}
