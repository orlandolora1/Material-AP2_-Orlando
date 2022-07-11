using System.ComponentModel.DataAnnotations;

public class Vitaminas
{
    [Key]
    public int VitaminaId { get; set; }
    public string Descripcion { get; set; }
    public int UnidadDeMedida { get; set; }
    
}