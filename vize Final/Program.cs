// See https://aka.ms/new-console-template for more information


for (int i = 1; i <=4; i++)
{
  
    Console.WriteLine(i + " .Öğrenci");
   
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(j + " .Ders");

        Console.Write("Vize Notunuz = ");
        int vize = Convert.ToInt32(Console.ReadLine());

        Console.Write("Final Notunuz = ");
        int final = Convert.ToInt32(Console.ReadLine());
        double ort = (vize* 0.4)+ (final * 0.6);
        Console.WriteLine(j + " .Dersinizin Ortalaması " + ort);

    }
    Console.WriteLine("----------------");
}
