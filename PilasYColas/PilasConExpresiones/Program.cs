namespace PilasConExpresiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una expresión: ");
            string expresion = Console.ReadLine();

            if (PilasExpresiones.EstaBalanceado(expresion))
            {
                Console.WriteLine("Los paréntesis están balanceados");

            }
            else
            {
                Console.WriteLine("Los paréntesis NO están balanceados");
            }
        }
    }
}
