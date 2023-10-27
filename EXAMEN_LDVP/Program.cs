using EXAMEN_LDVP.Metodos;

namespace EXAMEN_LDVP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordenados, ");
            Ejercicios CienNum = new Ejercicios();
            CienNum.CienNum();

            Console.WriteLine("Buscar un valor");
            Ejercicios binaria = new Ejercicios();
            binaria.Binaria();

        

           

        }
    }
}