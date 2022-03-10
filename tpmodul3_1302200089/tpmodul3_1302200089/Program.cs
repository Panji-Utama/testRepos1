using tpmodul3_1302200089;

class Program
{
    static void Main(string[] args)
    {
        //int satu;
        //console.write("masukkan angka: ");
        //satu = convert.toint32(console.readline());
        //console.writeline(satu);

        Console.WriteLine("Kelurahan  Kode pos");

        KodePos baru = new KodePos();
        baru.setKodePos("Batununggal", 40266);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Kujangsari", 40287);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Mengger", 40267);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Wates", 40256);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Cijaura", 40287);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Jatisari", 40286);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Margasari", 40286);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Sekejati", 40286);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Kebonwaru", 40272);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Maleer", 40274);
        Console.WriteLine(baru.getKodePos());
        baru.setKodePos("Samoja", 40273);
        Console.WriteLine(baru.getKodePos());

        Console.WriteLine("\n");
        Console.WriteLine("Door Machine dimulai");
        DoorMachine.Mulai();

    }
}