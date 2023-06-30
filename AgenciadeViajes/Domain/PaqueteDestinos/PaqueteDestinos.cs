using Domain.Primitives;

namespace Domain.PaqueteDestinos
{
    public sealed class PaqueteDestinos : AggregateRoot
    {
        private global::System.Boolean activo1 = default(;


        public PaqueteDestinos(PaqueteDestinosId id,int destinoId,int paqueteId,Destinos destinos,Paquetes paquetes,bool activo){
            this.Id = id;
            this.destinoId = destinoId;
            this.paqueteId = paqueteId;
            this.paquete = paquetes;
            this.destinos = destinos;
            this.Activo = activo;
        }

        public PaqueteDestinosId Id {get;private set;}
        public int paqueteId {get;private set;}
        public Paquetes paquete {get;private set;}
        public int destinoId {get;private set;}
        public Destinos destino {get;private set;}

        public bool activo { get => activo1; private set => activo1 = value; }

        public bool activo {get; private set;}; = default(true);
    }
}