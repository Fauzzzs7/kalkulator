class program
{
    static void Main(string[] args)
    {
        Console.Title = "Aplikasi Calculator";

        // int a = 10; // declarasi variabel a, dg nilai awal 10;
        // int b = 6; // declarasi variabel b, dg nilai awal 6;

        Console.Write("Inputkan nilai a = ");
        int a = int.Parse(Console.Readline()); // proses casting

        Console.Write("Inputkan nilai b = ");
        int b = Convert.ToInt32(Console.Readline()); // proses casting

        Console.WriteLine(); // tambahkan baris kosong

        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
        Console.WriteLine("Hasil Pengurangan {0} / {1} = {2}", a, b, Pembagian(a, b));

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();  
    }
}   