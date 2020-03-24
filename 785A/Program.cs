using System;
using System.Collections.Generic;

namespace _785A
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        //      Tetrahedron.Tetrahedron has 4 triangular faces.
        //      Cube.Cube has 6 square faces.
        //      Octahedron.Octahedron has 8 triangular faces.
        //      Dodecahedron.Dodecahedron has 12 pentagonal faces.
        //      Icosahedron.Icosahedron has 20 triangular faces.

        private static Dictionary<string, int> _faces = new Dictionary<string, int>
        {
            { "Tetrahedron", 4},
            { "Cube", 6},
            { "Octahedron", 8},
            { "Dodecahedron", 12},
            { "Icosahedron", 20},
        };

        static void Main(string[] args)
        {
            var n = GetInt();
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += _faces[Console.ReadLine()];
            }

            Console.WriteLine(sum);
        }
    }
}
