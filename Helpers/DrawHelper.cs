using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml.Helpers
{
    public static class DrawHelper
    {
        public static void DrawScreen(int column, int line)
        {
            DrawColumn(column);
            DrawLines(column, line);
            DrawColumn(column);
        }

        private static void DrawLines(int column, int line)
        {
            for (int lines = 0; lines <= line; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= column; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        private static void DrawColumn(int column)
        {
            Console.Write("+");
            for (int i = 0; i <= column; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            Console.Write("\n");
        }
    }
}
