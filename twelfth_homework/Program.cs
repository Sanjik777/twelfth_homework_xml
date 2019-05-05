using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Создать класс Car и описать его минимум 4-мя свойствами.
 Создать по этому классу вручную .json и .xml файл описывающий какой-либо объект класса Car
 */
namespace twelfth_homework
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car
			{
				Name="Gelik",
				Model="G500",
				Weight=2.5,
				Speed=200,
			};
		}
	}
}
