﻿//Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine(l);