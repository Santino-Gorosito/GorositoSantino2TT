namespace Entidades
{
    public class Cliente
    {
        public int ClienteId {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public List<Cuenta> Cuentas { get; set; }
    }
}
