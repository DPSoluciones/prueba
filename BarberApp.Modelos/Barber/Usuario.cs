
namespace BarberApp.Modelos.Barber
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("Tbl_Usuarios")]
    public class Usuario
    {
        /// <summary>
        /// Obtiene y establece la clave primaria del usuario.
        /// </summary>
        [Key]
        public int ID_Usuario { get; set; }


        /// <summary>
        /// Obtiene y establece una coleccion de reservas.
        /// </summary>
        public ICollection<Reserva> Reservas { get; set; }
    }
}
