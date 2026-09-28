using System;

class Program
{
    static void Main()
    {
        
        CuentaBancaria cuenta = new CuentaBancaria("12345");
        cuenta.Depositar(1000m);
        cuenta.Retirar(200m);
        cuenta.Retirar(1500m); 
        Console.WriteLine(cuenta.ObtenerSaldo());

        
        Temperatura temp = new Temperatura();
        temp.Celsius = 25;
        Console.WriteLine(temp.Celsius);
        temp.Celsius = -300; // Intento invalido (menor a -273)

        // 5. Uso de const IVA
        const decimal IVA = 0.21m;
        Console.WriteLine(IVA);

      
        Usuario user = new Usuario();
        user.Clave = "123456";

        // 8. Propiedad calculada Perimetro
        Rectangulo rect = new Rectangulo { Ancho = 5, Alto = 10 };
        Console.WriteLine(rect.Perimetro);

        Persona p = new Persona();
        p.Nombre = "Bauti";
        p.Edad = 18;
        Console.WriteLine($"{p.Nombre} - {p.Edad}");
        p.Edad = 200; // Intento invalido
    }
}


public class CuentaBancaria
{
    private decimal _saldo;
    private readonly string _idCuenta;

    public CuentaBancaria(string id)
    {
        _idCuenta = id;
        _saldo = 0;
    }

    public string IdCuenta => _idCuenta;

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            _saldo += monto;
        }
    }

    public void Retirar(decimal monto)
    {
        if (monto > 0 && monto <= _saldo)
        {
            _saldo -= monto;
        }
    }

    public decimal ObtenerSaldo()
    {
        return _saldo;
    }
}

// 4. Clase Temperatura
public class Temperatura
{
    private double _celsius;

    public double Celsius
    {
        get { return _celsius; }
        set
        {
            if (value >= -273.15)
            {
                _celsius = value;
            }
        }
    }
}


public class Usuario
{
    private string _clave;

    public string Clave
    {
        set { _clave = value; }
    }
}


public class Rectangulo
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public double Perimetro => 2 * (Ancho + Alto);
}


public class Persona
{
    private string _nombre;
    private int _edad;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int Edad
    {
        get { return _edad; }
        set
        {
            if (value >= 0 && value <= 150)
            {
                _edad = value;
            }
        }
    }
}