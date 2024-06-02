using System.ComponentModel.DataAnnotations;

namespace DMGestorDeTareasMagicMVC.Models
{
    public class DMPrioridad
    {
        [Key]
        public int DMPrioridadId { get; set; }
        public string? DMNombre { get; set; }
        public string? DMDescripcion { get; set; }

        // Propiedad de navegación hacia DMTarea
        public int DMTareaId { get; set; }
        public DMTarea? DMTarea { get; set; }
    }
}
