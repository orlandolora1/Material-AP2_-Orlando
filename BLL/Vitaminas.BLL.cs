using Microsoft.EntityFrameworkCore;

public class VitaminasBLL
    {
        private Contexto _contexto;
        public VitaminasBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

    
        public Vitaminas? Buscar(int Id)
        {
            return _contexto.Vitaminas
                .Where(p => p.VitaminaId == Id)
                .AsNoTracking()
                .SingleOrDefault();
         }
        public List<Vitaminas> GetList()
        {
            return _contexto.Vitaminas
                .AsNoTracking()
                .ToList();
        }
         privado bool Insertar ( Verduras  verdura )
        {
            _contexto . Verduras . Añadir ( verdura );
            // sumar el inventario de nuevo

            foreach ( var  item  en  verdura . Detalle )
            {
                var  vitamina  =  _contexto . Vitaminas . Buscar ( elemento . VitaminaId );
            privado bool Insertar(Verduras verduras)

            privado bool  Modificar ( Verduras  verdura )
        {

            // buscar el detalle anterior

               var  anterior  =  _contexto . Verduras
             . Donde ( c  =>  c . VerduraId  ==  verdura . VerduraId )
             . Incluir ( c  =>  c . Detalle )
             . como sin seguimiento ()
             . Único o por defecto ();


            // arreglar el inventario del detalle anterior

            foreach ( var  item  en  anterior . Detalle )
            {
                var  vitamina  =  _contexto . Vitaminas . Buscar ( elemento . VitaminaId );

                vitaminas _ UnidadDeMedida  -=  artículo . cantidad ;
            }

            // borrar los items del detalle primero

            _contexto . base de datos ExecuteSqlRaw ( $" DELETE FROM VerdurasDetalle WHERE VerduraId={ verdura . VerduraId }; " );

            // sumar inventario 

            foreach ( var  item  en  verdura . Detalle )
            {
                var  vitamina  =  _contexto . Vitaminas . Buscar ( elemento . VitaminaId );

            private bool Modificar(Verduras verduras)

            public  bool  Eliminar ( Verduras  verduras )
        {
              _contexto . Verduras . Añadir ( verdura );
            // sumar inventario 

            foreach ( var  item  en  verdura . Detalle )
            {
                var  vitamina  =  _contexto . Vitaminas . Buscar ( elemento . VitaminaId );
             vitamina.UnidadDeMedida -= item.Cantidad;
            }
                _contexto.Entry(verdura).State = EntityState.Deleted;
            private bool elimino = _contexto.SaveChanges() > 0;
                _contexto.Entry(verdura).State = EntityState.Detached;
                return elimino;
        }
            public Verduras? Buscar(int verdura)
        {
            return _contexto.Verduras
                .Include(c => c.Detalle)
                .Where(c => c.VerduraId == verdura)
                .AsNoTracking()
                .SingleOrDefault();
        }
            public List<Verduras> GetList()
         {
            return _contexto.Verduras.AsNoTracking().ToList();
        }
        
    }
    }