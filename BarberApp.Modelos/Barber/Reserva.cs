
namespace BarberApp.Modelos.Barber
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("Tbl_Reservas")]
    public class Reserva
    {

        /// <summary>
        /// Obtiene y establece la clave primaria de la Reserva.
        /// </summary>
        [Key]
        public int ID_Reserva { get; set; }


        [ForeignKey("Usuario")]
        public int FK_ID_Usuario { get; set; }

        [ForeignKey("ID_Usuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
