using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.Title = "Snake";
			Console.SetWindowSize(1, 1);
			Console.SetBufferSize(80, 25);
			Console.SetWindowSize(80, 25);
			Console.ForegroundColor = ConsoleColor.Green;

			// Отрисовка рамочки
			HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
			VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
			// В данном случае размер игрового окна будет зависеть от фактического размера консоли
			/*
			HorizontalLine upLine = new HorizontalLine(0, Console.BufferWidth - 1, 0, '*');
			HorizontalLine downLine = new HorizontalLine(0, Console.BufferWidth - 1, Console.BufferHeight - 1, '');
			VerticalLine leftLine = new VerticalLine(0, Console.BufferHeight - 1, 0, '');
			VerticalLine rigthLine = new VerticalLine(0, Console.BufferHeight - 1, Console.BufferWidth - 1, '');
			*/
			upLine.Draw();
			downLine.Draw();
			leftLine.Draw();
			rightLine.Draw();
			
			// Отрисовка точек
			Point p = new Point(3, 11, '*');
			Snake snake = new Snake(p, 7, Direction.DOWN);
			snake.Draw();

			Console.ReadKey();
		
		}

     }
}