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

        public Cliente() { }
        public Cliente(string nombre, string apellido, string dni, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            Cuentas = new List<Cuenta>();
        }
    }
}
