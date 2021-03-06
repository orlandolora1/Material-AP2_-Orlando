using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Verduras> Verduras { get; set; }
    public DbSet<Vitaminas> Vitaminas { get; set; }
     public Contexto(DbContextOptions<Contexto>  options) : base(options)    
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Vitaminas>().HasData(
            new Vitaminas{
                VitaminaId = 1,
                Descripcion="Vitamina A (mcg RAE)",
                UnidadDeMedida=90
                Existencia = 3
            },
            new Vitaminas{
                VitaminaId = 2,
                Descripcion="Vitamina E (mg)",
                UnidadDeMedida =1.54
                Existencia = 6
            },
            new Vitaminas{
                VitaminaId =3,
                Descripcion ="Vitamina K (mcg)",
                UnidadDeMedida =390
                Existencia = 9
            },
            new Vitaminas{
                VitaminaId =4,
                Descripcion="Vitamina C (mg)",
                UnidadDeMedida=120
                Existencia = 12
            },
            new Vitaminas{
                VitaminaId =5,
                Descripcion="Betaína (mg)",
                UnidadDeMedida = 700
                Existencia = 15
            }, 
            new Vitaminas{
                VitaminaId = 6,
                Descripcion ="Tiamina(B1) (mg)",
                UnidadDeMedida=0.11
                Existencia = 18
            },
            new Vitaminas{
                VitaminaId =7,
                Descripcion = "Riboflavina(B2) (mg)",
                UnidadDeMedida = 0.13
                Existencia = 21
            },
            new Vitaminas{
                VitaminaId =8,
                Descripcion="Ácido fólico(B9) (mg)",
                UnidadDeMedida= 400
                Existencia = 23
            },
            new Vitaminas{
                VitaminaId =9,
                Descripcion="Choline (mg)",
                UnidadDeMedida =0.8
                Existencia = 25
            },
            new Vitaminas{
                VitaminaId=10,
                Descripcion="Folate(B9) (μg)",
                UnidadDeMedida = 141
                Existencia = 28
            }
        );

    }
}