namespace Shoes.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int IdUser { get; set; }

        public int RoleId { get; set; }

        [Required]
        [StringLength(150)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

        public virtual Role Role { get; set; }

        public bool isGuest() {
            bool result = (this.Role.RoleName == "Гость");
            return result;
        }

        public bool isAdmin()
        {
            bool result = (this.Role.RoleName == "Администратор");
            return result;
        }

        public bool isManager()
        {
            bool result = (this.Role.RoleName == "Менеджер");
            return result;
        }
    }
}
