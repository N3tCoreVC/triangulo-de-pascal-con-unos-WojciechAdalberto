using System;

namespace triangulo_de_pascal_con_unos_WojciechAdalberto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Longitud;
            Longitud = 5;
            ImprimeTriangulo(Longitud);
        }

        static void ImprimeTriangulo(int VLongitud)
        {
            for ( int i = 1 ; i <= VLongitud ; i++ )
            {
                for ( int j= VLongitud - i ; j>0 ; j-- )
                    Console.Write(" ");
                for ( int j=0 ; j < i ; j++ )
                    Console.Write("1 ");
                Console.WriteLine();
            }
            return;
        }
    }
}
