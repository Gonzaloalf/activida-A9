Console.WriteLine("SISTEMA DE MONITOREO DE MOTORES");
Console.WriteLine();

// Lista para guardar varios objetos de la clase Motor
List<Motor> motores = new List<Motor>();

Console.Write("Ingrese la cantidad de motores a registrar: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

// Capturar la información de cada motor
for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine();
    Console.WriteLine($"--- Motor {i} ---");

    // Crear un objeto de la clase Motor
    Motor motor = new Motor();

    Console.Write("Ingrese el identificador del motor: ");
    motor.Identificador = Console.ReadLine() ?? "Sin identificador";

    Console.Write("Ingrese la temperatura (°C): ");
    motor.Temperatura = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese la corriente (A): ");
    motor.Corriente = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese la velocidad (RPM): ");
    motor.Velocidad = Convert.ToDouble(Console.ReadLine());

    // Agregar el objeto a la lista
    motores.Add(motor);
}

// Mostrar resultados de todos los motores
Console.WriteLine();
Console.WriteLine("===== RESULTADOS =====");

foreach (Motor m in motores)
{
    Console.WriteLine();
    m.MostrarDatos();
}


// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";

    public double Temperatura { get; set; }

    public double Corriente { get; set; }

    public double Velocidad { get; set; }


    // Método para evaluar la temperatura
    public string EvaluarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "TEMPERATURA ALTA (mayor a 70 °C)";
        }
        else
        {
            return "TEMPERATURA NORMAL";
        }
    }


    // Método para determinar si el motor está detenido o en marcha
    public string ObtenerEstadoMarcha()
    {
        if (Velocidad == 0)
        {
            return "DETENIDO";
        }
        else
        {
            return "EN MARCHA";
        }
    }


    // Método para mostrar los datos del motor
    public void MostrarDatos()
    {
        Console.WriteLine($"Identificador: {Identificador}");
        Console.WriteLine($"Temperatura: {Temperatura:F1} °C");
        Console.WriteLine($"Corriente: {Corriente:F2} A");
        Console.WriteLine($"Velocidad: {Velocidad:F0} RPM");
        Console.WriteLine($"Estado de temperatura: {EvaluarTemperatura()}");
        Console.WriteLine($"Estado del motor: {ObtenerEstadoMarcha()}");
    }
}