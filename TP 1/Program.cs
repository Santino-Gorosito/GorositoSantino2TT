using System.ComponentModel.Design;
using TP_1;

Banco banco = new Banco();


Console.WriteLine("BIENVENIDO AL SISTEMA BANCARIO UAI\n");

// LOGIN

Login();

//------------------------------------------

void Login()
{
    int opcion = 0;

    Console.WriteLine("OPCIONES DE LOGEO\n");


    bool opcionValida = false;

    while (opcionValida == false)
    {
        Console.WriteLine("1. Iniciar Sesión");
        Console.WriteLine("2. Registrarse\n");

        Console.Write("Seleccione una opcion: ");
        string opcionLogin = Console.ReadLine();

        try
        {
            opcion = Convert.ToInt32(opcionLogin);

            if (opcion != 1 && opcion != 2)
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

            Console.WriteLine("Ingrese nombre de usuario");
            string logNomUsuario = Console.ReadLine();

            Cliente usuario = banco.buscarUsuarioPorNombre(logNomUsuario);

            if (usuario == null)
            {
                Console.WriteLine("Ese usuario no esta registrado");
            }
            else
            {
                Console.WriteLine("Ingrese la contraseña de usuario");
                string contraseña = Console.ReadLine();

                if (usuario.Contraseña != contraseña)
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
                else
                {
                    MenuDeOperaciones();
                }
            }

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

                
                Cliente regUser = banco.buscarUsuarioPorNombre(regNomUsuario);
                bool dniExiste = banco.existeDni(dniUsuario);

                if (regUser != null || dniExiste)
                {
                    Console.WriteLine("Ya existe un usuario con ese nombre o DNI \n");
                    continue; 
                }

                Cliente nuevoUser = new Cliente(dniUsuario, regNomUsuario, regConUsuario, regTelUsuario, regMailUsuario, fechaNacimiento);
                banco.agregarUsuario(nuevoUser);
                
                Console.WriteLine("Usuario registrado con éxito.\n");
                regValido = true; 
            }
            break;

    }
}

void MenuDeOperaciones()
{

}

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
