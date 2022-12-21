using System;

class Tugas_Kelompok_Terkecil
{
    public static void Main()
    {
        int A, B, C, D, Bilangan;

        Console.Write("Masukana Bilangan A : ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukana Bilangan B : ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukana Bilangan C : ");
        C = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukana Bilangan D : ");
        D = Convert.ToInt32(Console.ReadLine());

        if (A > B)
        {
            if (A > C)
            {
                if (A > D)
                {
                    Bilangan = A;
                }
                else
                {
                    Bilangan = D;
                }
            }
            else
            {
                if (C > D)
                {
                    Bilangan = C;
                }
                else
                {
                    Bilangan = D;
                }
            }
        }
        else
        {
            if (B > C)
            {
                if (B > D)
                {
                    Bilangan = B;
                }
                else
                {
                    Bilangan = D;
                }
            }
            else
            {
                if (C > D)
                {
                    Bilangan = C;
                }
                else
                {
                    Bilangan = D;
                }
            }
        }

        Console.WriteLine($"Bilangan A = {A}");
        Console.WriteLine($"Bilangan B = {B}");
        Console.WriteLine($"Bilangan C = {C}");
        Console.WriteLine($"Bilangan D = {D}");
        Console.WriteLine($"Bilangan Terkecil Adalah {Bilangan}");

    }
}