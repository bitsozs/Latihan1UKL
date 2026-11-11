int hargaDasar = 50000;
int hargaTambahan = 0;
Console.Write("Masukkan Hari (Senin, Selasa, Rabu, Kamis, Jumat, Sabtu, Minggu): ");
string day = Console.ReadLine().ToLower();
Console.Write("Masukkan Umur: ");
int umur = int.Parse(Console.ReadLine());

switch (day)
{
    case "saturday":
        hargaTambahan += 10000;
        break;

    case "sunday":
        hargaTambahan += 10000;
        break;
}

if (umur < 12 || umur > 60)
{
    hargaDasar -= 10000;
}

Console.WriteLine($"\nYang harus dibayarkan Rp {hargaDasar + hargaTambahan}");