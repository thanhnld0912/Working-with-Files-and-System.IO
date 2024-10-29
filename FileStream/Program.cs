using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** Demo FileStream");
        using FileStream fStream = File.Open("MyFIle.dat", FileMode.Create);
        string msg = "abcdefghjikl";
        byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
        fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
        fStream.Position = 0;
        Console.Write("Print message: \n");
        byte[] byteFromFile = new byte[msgAsByteArray.Length];
        for (int i = 0; i < byteFromFile.Length; i++)
        {
            byteFromFile[i] = (byte)fStream.ReadByte();
            Console.Write($"{byteFromFile[i],5}");
        }
        Console.WriteLine("Decode: ");
        Console.WriteLine(Encoding.Default.GetString(byteFromFile));
        Console.ReadLine();
    }
}