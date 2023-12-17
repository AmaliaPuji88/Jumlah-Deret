using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan Jumlah Deret: ");
        int jumlahDeret = Convert.ToInt32(Console.ReadLine());

        // Menampilkan deret
        for (int i = 1; i <= jumlahDeret; i++)
        {
            // Menampilkan angka dari 1 hingga i
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
                if (j < i)
                {
                    Console.Write("-");
                }
            }

            // Menambahkan '+' di akhir baris kecuali pada baris terakhir
            if (i < jumlahDeret)
            {
                Console.Write("+");
            }

            Console.WriteLine();
        }
    }
}

