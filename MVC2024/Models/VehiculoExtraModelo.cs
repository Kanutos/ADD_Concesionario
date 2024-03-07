namespace MVC2024.Models
{
    public class VehiculoExtraModelo
    {
        public int ID {  get; set; }
        public int extraID { get; set; }//ref a la clase extra modelo
        public ExtraModelo extra { get; set; }//Clave foranea
        public int vehiculoID { get; set; }
        public VehiculoModelo vehiculo { get; set;}
    }
}
