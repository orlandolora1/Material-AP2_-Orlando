using System.ComponentModel.DataAnnotations;

public class Vitaminas
{
    [Key]
    public int VitaminaId { get; set; }
    public string Descripcion { get; set; }
    public string UnidadDeMedida { get; set; }
    public int Existencia { get; set; }
}