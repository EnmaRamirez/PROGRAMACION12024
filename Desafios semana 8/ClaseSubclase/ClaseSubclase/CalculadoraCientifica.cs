using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSubclase
{
    public class CalculadoraCientifica : Calculadora
    {
        //Metodos
        public double Potencia(double numero, double exponente)
        {
            return Math.Pow(numero, exponente);
        }
        public double Raiz(double numero)
        {
            return Math.Sqrt(numero);
        }
        public double Modulo(double numero1, double numero2)
        {
            return numero1 % numero2;
        }
        public double Logaritmo(double numero, double baseLog)
        {
            return Math.Log(numero, baseLog);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            //Instancia de la clase calculadora
            Calculadora CalculadoraBasica = new Calculadora();
            CalculadoraBasica.Marca = "Generico";
            CalculadoraBasica.Serie = "123";

            //Instancia de la calculadora Cientifica
            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();
            calculadoraCientifica.Marca = "Cientifica";
            calculadoraCientifica.Serie = "456";

            Console.WriteLine("Calculadora Basica: ");
            Console.WriteLine("Suma: " + CalculadoraBasica.Sumar(20, 8));
            Console.WriteLine("Resta: " + CalculadoraBasica.Restar(20, 8));
            Console.WriteLine("Multiplicacion: " + CalculadoraBasica.Multiplicar(20, 8));
            Console.WriteLine("Divicion: " + CalculadoraBasica.Dividir(20, 8));

            Console.WriteLine("\nCalculadora Cientifica: ");
            Console.WriteLine("Potencia: " + calculadoraCientifica.Potencia(4, 6));
            Console.WriteLine("Raiz cuadrada: " + calculadoraCientifica.Raiz(18));
            Console.WriteLine("Modulo: " + calculadoraCientifica.Modulo(12, 9));
            Console.WriteLine("Logaritmo: " + calculadoraCientifica.Logaritmo(100, 10));


        }
    }
}
