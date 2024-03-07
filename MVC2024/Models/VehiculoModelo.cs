using System.ComponentModel.DataAnnotations.Schema;

namespace MVC2024.Models
{
    public class VehiculoModelo
    {
        public int Id { get; set; }
        public String Matricula { get; set; }
        public String Color { get; set; }
        public int SerieId {get; set;}
        public int SucursalId { get; set; }
        public SerieModelo Serie { get; set; }
        public SucursalModelo Sucursal { get; set; }


        [NotMapped]//PARA QUE NO MAPEE A LAS TABLAS PERO PODAMOS TRABAJAR CON ESE ATRIBUTO, SOLO AFECTA AL SIGUIENTE
        public List<int> ExtrasSeleccionados { get; set; }
        public List<VehiculoExtraModelo> VehiculoExtras { get; set; }//Objetos en memoria, estable relacion con la BDD

    }
}
