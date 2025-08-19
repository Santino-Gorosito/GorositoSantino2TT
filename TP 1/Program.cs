using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using TP_1;

// =========================
// DECLARACION DE REPOSITORIO Y HARCODEO ADMIN

Banco banco = new Banco();

Admin admin = new Admin(123456, "Santino", "kikoloco", "341318-3054", "gorositotomas82@gmail.com", DateTime.Now);
banco.Usuarios.Add(admin);

// =========================

// =========================
// INICIO PROGRAMA

Console.WriteLine("BIENVENIDO AL SISTEMA BANCARIO UAI\n");
Login();

// =========================

// =========================
// FUNCIONES DE LOGIN
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
// =========================


// =========================
//        MENU USUARIO

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
            Ingresar(cliente);
            break;
        case "3":
            Extraer(cliente);
            break;
        case "4":
            Modificar(cliente);
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
void Ingresar(Cliente cliente)
{
    Console.Clear();

    bool numCuentaValido = false;
    int numCuenta = 0;


    while (!numCuentaValido)
    {
        Console.Write("Ingrese el numero de cuenta para ingresar dinero. 'Salir' para volver al menu de operaciones:");
        string inputNumCuenta = Console.ReadLine();

        if (inputNumCuenta == "Salir")
        {
            MenuDeOperacionesCliente(cliente);
        }

        try
        {
            numCuenta = Convert.ToInt32(inputNumCuenta);
        }
        catch (Exception ex)
        {
            Console.Write("Ingrese un numero entero");
        }

        Cuenta cuenta = banco.obtenerCuenta(numCuenta);

        if (cuenta == null)
        {
            Console.WriteLine("El numero de cuenta no existe");
        }
        else
        {
            bool montoValido = false;
            int monto = 0;

            while (!montoValido)
            {

                Console.Write("Ingrese el monto. 'Salir' para volver al menu de operaciones: ");
                string inputMonto = Console.ReadLine();

                if (inputMonto == "Salir")
                {
                    MenuDeOperacionesCliente(cliente);
                }



                try
                {
                    monto = Convert.ToInt32(inputMonto);

                    if (monto <= 0)
                    {
                        Console.WriteLine("Ingrese un monto mayor a 0");
                    }
                    else
                    {
                        montoValido = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ingrese un numero entero");
                }
            }

            cuenta.Ingresar(monto);

            Ingreso ingreso = new Ingreso(DateTime.Now, monto);
            banco.Movimientos.Add(ingreso);

            numCuentaValido = true;
        }
    }
}
void Extraer(Cliente cliente)
{
    Console.Clear();

    bool numCuentaValido = false;
    int numCuenta = 0;


    while (!numCuentaValido)
    {
        Console.Write("Ingrese el numero de cuenta para extraer dinero. 'Salir' para volver al menu de operaciones:");
        string inputNumCuenta = Console.ReadLine();

        if (inputNumCuenta == "Salir")
        {
            MenuDeOperacionesCliente(cliente);
        }

        try
        {
            numCuenta = Convert.ToInt32(inputNumCuenta);
        }
        catch (Exception ex)
        {
            Console.Write("Ingrese un numero entero");
        }

        Cuenta cuenta = banco.obtenerCuenta(numCuenta);

        if (cuenta == null)
        {
            Console.WriteLine("El numero de cuenta no existe");
        }
        else
        {
            bool montoValido = false;
            int monto = 0;

            while (!montoValido)
            {

                Console.Write("Ingrese el monto. 'Salir' para volver al menu de operaciones: ");
                string inputMonto = Console.ReadLine();

                if (inputMonto == "Salir")
                {
                    MenuDeOperacionesCliente(cliente);
                }

                try
                {
                    monto = Convert.ToInt32(inputMonto);

                    if (monto <= 0)
                    {
                        Console.WriteLine("Ingrese un monto mayor a 0");
                    }
                    else
                    {
                        montoValido = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ingrese un numero entero");
                }
            }

            if (cuenta.Extraer(monto))
            {
                banco.Movimientos.Add(new Egreso(DateTime.Now, monto));
                Console.WriteLine("Extraccion exitosa");
            }
            else
            {
                Console.WriteLine("No se pudo realizar la extraccion");
            }
        }
    }
}
void Modificar(Cliente cliente)
{
    Console.Clear();

    Console.WriteLine("EDICION DE INFORMACION PERSONAL\n");

    bool nombreNuevoValido = false;

    while (!nombreNuevoValido)
    {
        Console.Write("Nuevo nombre (Enter para saltear):");
        string nuevoNombre = Console.ReadLine();

        if (string.IsNullOrEmpty(nuevoNombre)) {
            nombreNuevoValido = true;
        } else
        {
            Usuario existeCliente = banco.buscarUsuarioPorNombre(nuevoNombre);

            if (existeCliente == null) {
                cliente.Nombre = nuevoNombre;
                nombreNuevoValido = true;
            } else
            {
                Console.WriteLine("El nombre de usuario ya existe");
            }
        }
    }

    bool nuevoDniValido = false;

    while (!nuevoDniValido) {
        Console.Write("Nuevo DNI (Enter para saltear):");
        string nuevoDni = Console.ReadLine();

        int dniNuevo = 0;

        if (string.IsNullOrEmpty(nuevoDni))
        {
            nuevoDniValido = true;
        }

        try
        {
            dniNuevo = Convert.ToInt32(nuevoDni);

            bool existe = banco.existeDni(dniNuevo);

            if (existe) {
                Console.WriteLine("Ya existe un usuario con ese mismo dni");
            } else
            {
                cliente.Dni = dniNuevo;
                nuevoDniValido = true;
            }
        }
        catch (Exception ex) {
            Console.WriteLine("Ingrese un numero entero");
        }

    }

    bool telefonoNuevoValido = false;

    while (!telefonoNuevoValido)
    {
        Console.Write("Nuevo Telefono (Enter para saltear):");
        string nuevoTelefono = Console.ReadLine();

        if (string.IsNullOrEmpty(nuevoTelefono))
        {
            telefonoNuevoValido = true;
        }
        else
        {
            cliente.Telefono = nuevoTelefono;
            telefonoNuevoValido = true;
        }
    }

    bool mailNuevoValido = false;

    while (!mailNuevoValido)
    {
        Console.Write("Nuevo Mail (Enter para saltear):");
        string nuevoMail = Console.ReadLine();

        if (string.IsNullOrEmpty(nuevoMail))
        {
            mailNuevoValido = true;
        }
        else
        {
            cliente.Mail = nuevoMail;
            mailNuevoValido = true;
        }
    }

    bool fechaValida = false;
    bool edadValida = false;
    DateTime nuevaFecha = DateTime.Now;

    while (!fechaValida)
    {
        Console.Write("Nueva fecha de nacimiento (dd/MM/yyyy) [Enter para saltear]: ");
        string inputFecha = Console.ReadLine();

        if (string.IsNullOrEmpty(inputFecha))
        {
            fechaValida = true;
        }
        else if (DateTime.TryParseExact(inputFecha, "dd/MM/yyyy",
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None, out nuevaFecha) && EdadValida(nuevaFecha))
        {
            cliente.FechaNacimiento = nuevaFecha;
            fechaValida = true;
        }
        else
        {
            Console.WriteLine("Fecha de nacimiento invalida");
        }
    }

    bool contraseñaNuevaValida = false;

    while (!contraseñaNuevaValida)
    {
        Console.Write("Nueva contraseña (Enter para saltear):");
        string nuevaContraseña = Console.ReadLine();

        if (string.IsNullOrEmpty(nuevaContraseña))
        {
            contraseñaNuevaValida = true;
        }
        else
        {
            cliente.Contraseña = nuevaContraseña;
            contraseñaNuevaValida = true;
        }
    }

    MenuDeOperacionesCliente(cliente);
}

// =========================


// MENU DE ADMIN

void MenuDeOperacionesAdmin(Admin admin)
{
    Console.Clear();

    Console.WriteLine("Menu de operaciones de ADMINISTRADOR\n");

    Console.WriteLine("Menu de opciones:\n");

    Console.WriteLine("1. Listado de clientes");
    Console.WriteLine("2. Eliminar clientes sin cuentas");
    Console.WriteLine("3. Eliminar cuentas sin saldo");
    Console.WriteLine("4. Reasignar titular de una cuenta\n");

    Console.Write("Seleccione la opcion 'Salir' para volver al login:");
    string opcionInput = Console.ReadLine();

    if (opcionInput == "Salir")
    {
        Login();
    }

    switch (opcionInput) {
        case "1":
            ListarClientes();
            break;
        case "2":
            banco.EliminarClientesSinCuentas();
            break;
        case "3":
            banco.EliminarCuentas();
            break;
        case "4":
            ReasignarTitular();
            break;
    }

}

void ListarClientes()
{
    Console.Clear();

    Console.WriteLine("1. Listar todos los clientes");
    Console.WriteLine("2. Buscar por DNI");

    Console.Write("Opcion:");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":

            foreach (Usuario u in banco.Usuarios)
            {
                Console.WriteLine($"{u.Nombre} | {u.Dni}");
            }

            break;
        case "2":

            bool dniValido = false;

            while (!dniValido)
            {
                Console.Write("Ingrese el dni del usuario 'Salir' para volver al menu de admin:");
                string dniInput = Console.ReadLine();

                if (dniInput == "Salir")
                {
                    MenuDeOperacionesAdmin(admin);
                    return;
                }

                int dni = 0;

                try
                {
                    dni = Convert.ToInt32(dniInput);
                    Usuario user = banco.buscarUsuarioPorDNI(dni);

                    if (user == null) {
                        Console.WriteLine("No existe ese usuario");
                    } else
                    {
                        Console.WriteLine($"{user.Nombre} | {user.Dni} | {user.FechaNacimiento}");
                        dniValido = true;
                        Console.WriteLine("\nPresione una tecla para volver al menu");
                        Console.ReadKey();
                        MenuDeOperacionesAdmin(admin);
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine("Ingrese un numero entero");
                }
            }
            break;
        default:
            MenuDeOperacionesAdmin(admin);
            break;
    }
}
void ReasignarTitular()
{
    Console.WriteLine("")
}



// =========================


// =========================
// FUNCIONES ADICIONALES
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


// =========================



