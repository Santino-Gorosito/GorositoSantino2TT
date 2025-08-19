using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using TP_1;

Banco banco = new Banco();

// HARCODEO DE ADMIN

Admin admin = new Admin(123456, "Santino", "kikoloco", "341318-3054", "gorositotomas82@gmail.com", DateTime.Now);
banco.Usuarios.Add(admin);

Console.WriteLine("BIENVENIDO AL SISTEMA BANCARIO UAI\n");

// LOGIN

Login();

//------------------------------------------

void Login()
{
    Console.Clear();

    int opcion = 0;

    Console.WriteLine("OPCIONES DE LOGEO\n");


    bool opcionValida = false;

    while (opcionValida == false)
    {
        Console.WriteLine("1. Iniciar Sesión");
        Console.WriteLine("2. Registrarse");
        Console.WriteLine("3. Salir\n");

        Console.Write("Seleccione una opcion: ");
        string opcionLogin = Console.ReadLine();

        try
        {
            opcion = Convert.ToInt32(opcionLogin);

            if (opcion != 1 && opcion != 2 && opcion != 3)
            {
                Console.WriteLine("\nIngrese una opcion valida\n");
            }
            else
            {
                opcionValida = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nPorfavor ingrese un numero valido\n");
        }

    }

    switch (opcion)
    {
        case 1:

            Console.Clear();
            IniciarSesion();
            break;
        case 2:
            Console.Clear();
            bool regValido = false;

            while (!regValido)
            {
                Console.Write("Ingrese nombre de usuario: ");
                string regNomUsuario = Console.ReadLine();

                Console.Write("Ingrese su DNI: ");
                string regDniUsuario = Console.ReadLine();

                Console.Write("Ingrese su mail: ");
                string regMailUsuario = Console.ReadLine();

                Console.Write("Ingrese su telefono: ");
                string regTelUsuario = Console.ReadLine();

                Console.Write("Ingrese una contraseña de usuario: ");
                string regConUsuario = Console.ReadLine();

                DateTime fechaNacimiento = DateTime.Now;
                bool fechaValida = false;

                bool edadValida = false;

                while (!edadValida)
                {
                    while (!fechaValida)
                    {
                        Console.Write("Ingrese su fecha de nacimiento (dd/MM/yyyy): ");
                        string inputFecha = Console.ReadLine();


                        if (DateTime.TryParseExact(inputFecha, "dd/MM/yyyy",
                            System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None, out fechaNacimiento))
                        {
                            fechaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Formato de fecha invalido");
                        }
                    }

                    edadValida = EdadValida(fechaNacimiento);
                }

                if (string.IsNullOrWhiteSpace(regNomUsuario) || string.IsNullOrWhiteSpace(regDniUsuario) ||
                    string.IsNullOrWhiteSpace(regMailUsuario) || string.IsNullOrWhiteSpace(regTelUsuario) ||
                    string.IsNullOrWhiteSpace(regConUsuario))
                {
                    Console.WriteLine("No puede dejar datos vacios\n");
                    continue; 
                }

               
                if (!int.TryParse(regDniUsuario, out int dniUsuario))
                {
                    Console.WriteLine("Debe ingresar un DNI valido\n");
                    continue; 
                }

                
                Usuario regUser = banco.buscarUsuarioPorNombre(regNomUsuario);
                bool dniExiste = banco.existeDni(dniUsuario);

                if (regUser != null || dniExiste)
                {
                    Console.WriteLine("Ya existe un usuario con ese nombre o DNI \n");
                    continue; 
                }

                Cliente nuevoUser = new Cliente(dniUsuario, regNomUsuario, regConUsuario, regTelUsuario, regMailUsuario, fechaNacimiento, DateTime.Now);
                banco.agregarUsuario(nuevoUser);
                
                Console.WriteLine("Usuario registrado con exito\n");
                MenuDeOperacionesCliente(nuevoUser);
                regValido = true; 
            }
            break;
        case 3:
            Environment.Exit(0);
            break;

    }
}

void IniciarSesion()
{
    Console.Clear();

    bool nombreValido = false;

    while (!nombreValido)
    {
        Console.Write("Ingrese nombre de usuario. 'Salir' para volver al inicio: ");
        string logNomUsuario = Console.ReadLine();

        if (logNomUsuario == "Salir")
        {
            Login();
            return;
        }

        Usuario usuario = banco.buscarUsuarioPorNombre(logNomUsuario);

        if (usuario == null)
        {
            Console.WriteLine("Ese usuario no está registrado");
        }
        else
        {
            bool contraseñaValida = false;

            while (!contraseñaValida)
            {
                Console.Write("Ingrese la contraseña: ");
                string contraseña = Console.ReadLine();

                if (usuario.Contraseña != contraseña)
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
                else
                {
                    // Distinción entre Cliente y Admin
                    if (usuario is Cliente cliente)
                    {
                        MenuDeOperacionesCliente(cliente);
                    }
                    else if (usuario is Admin admin)
                    {
                        MenuDeOperacionesAdmin(admin);
                    }
                    contraseñaValida = true;
                    nombreValido = true;
                }
            }
        }
    }
}
//_________________________________________________________________________________________________________

// Menu de operaciones de usuario

void MenuDeOperacionesCliente(Cliente cliente)
{
    Console.Clear();

    Console.WriteLine($"Sesion iniciada como {cliente.Nombre}\n");
    Console.WriteLine("Menu de operaciones:\n");

    Console.WriteLine("1. Crear cuenta");
    Console.WriteLine("2. Ingresar dinero");
    Console.WriteLine("3. Extraer dinero");
    Console.WriteLine("4. Modificar informacion personal\n");

    bool opcionValida = false;
    string opcionElegida = "";
    while (!opcionValida)
    {
        Console.WriteLine("Seleccione la operacion a realizar. 'Salir' para volver al login: ");
        opcionElegida = Console.ReadLine();

        if (opcionElegida == "Salir")
        {
            Login();
        }

        if (string.IsNullOrWhiteSpace(opcionElegida) || (opcionElegida != "1" && opcionElegida != "2" && opcionElegida != "3" && opcionElegida != "4")) {
            Console.WriteLine("Opcion incorrecta");
        } else
        {
            opcionValida = true;
        }
    }

    switch (opcionElegida)
    {
        case "1":
            CreacionCuenta(cliente);
            break;
        case "2":
            Console.Clear();

            Console.WriteLine("Ingrese el numero de cuenta para ingresar dinero");
            break;
    }

}

void CreacionCuenta(Cliente cliente)
{
    Console.Clear();

    Console.WriteLine("Creacion de cuenta bancaria");
    Console.WriteLine("1. Cuenta corriente");
    Console.WriteLine("2. Caja ahorro\n");

    bool opcionValida = false;
    string opcionElegida = "";
    while (!opcionValida)
    {
        Console.Write("Seleccione una opcion. 'Salir' para volver al menu de operaciones:");
        opcionElegida = Console.ReadLine();

        if (opcionElegida == "Salir")
        {
            MenuDeOperacionesCliente(cliente);
        }

        if (string.IsNullOrWhiteSpace(opcionElegida) || (opcionElegida != "1" && opcionElegida != "2")) {
            Console.WriteLine("Seleccione una opcion valida");
        } else
        {
            opcionValida = true;
        }
    }

    switch (opcionElegida)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Creacion de cuenta corriente");

            if (cliente.CuentasCorrientes.Count == 2) {
                Console.WriteLine("Lo sentimos alcanzo el maximo de cuentas corrientes creadas");
                MenuDeOperacionesCliente(cliente);
            } else
            {
                int numeroCuenta = GenerarNumeroCuenta();

                CuentaCorriente cuentaCorriente = new CuentaCorriente(cliente, numeroCuenta);
                cliente.CuentasCorrientes.Add(cuentaCorriente);
                banco.agregarCuenta(cuentaCorriente);

                Console.WriteLine($"Cuenta creada correctamente con el numero {cuentaCorriente.Codigo}");
                MenuDeOperacionesCliente(cliente);
            }
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Creacion de caja de ahorro");

            if (cliente.CajasAhorro.Count == 1)
            {
                Console.WriteLine("Lo sentimos no puede crear mas de 1 caja de ahorro");
                MenuDeOperacionesCliente(cliente);
            }
            else
            {
                int numeroCuenta = GenerarNumeroCuenta();

                CajaAhorro cajaAhorro = new CajaAhorro(cliente, numeroCuenta);
                cliente.CajasAhorro.Add(cajaAhorro);
                banco.agregarCuenta(cajaAhorro);

                Console.WriteLine($"Caja creada correctamente con el numero {cajaAhorro.Codigo}");
                MenuDeOperacionesCliente(cliente);
            }
            break;
    }
}

//_________________________________________________________________________________________________________

// Menu de operaciones de ADMIN

void MenuDeOperacionesAdmin(Admin admin)
{
    Console.Clear();

    Console.WriteLine("Menu de operaciones de ADMINISTRADOR\n");

    Console.WriteLine("Menu de opciones:\n");







}

// ________________________________________________________________________________________________________

// Verificacion de edad requerida para logeo

bool EdadValida(DateTime fechaNac)
{
    bool valida = false;

    DateTime hoy = DateTime.Now;

    
    int edad = hoy.Year - fechaNac.Year;

    // Ajustar si aún no cumplió años este año
    if (fechaNac > hoy.AddYears(-edad))
    {
        edad--;
    }

    if (edad >= 18)
    {
        return valida = true;
    } else
    {
        return valida;
    }
}

//__________________________________________________________________________________________________________

// Creacion numero de cuenta aleatorio

int GenerarNumeroCuenta()
{
    Random rnd = new Random();
    int numCuenta;
    do
    {
        numCuenta = rnd.Next(100000, 999999); // número de 6 dígitos
    } while (banco.Cuentas.Any(c => c.Codigo == numCuenta));

    return numCuenta;
}



