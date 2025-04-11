namespace File
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "";

            for (int i = 0; i < 1000; i++)
            {
                data += $"Имя_{i};Фамилия_{i};Город_{Random.Shared.Next(1, 10)};8 800 555 ** **\n";
            }
            File.WriteAllText("personsData.csv", data);

            string[] dataRead = File.ReadAllText("personsData.csv").Split('\n');
            //foreach (string item in dataRead)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] personInfo = dataRead[0].Split(";");
            //foreach (string item in personInfo)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < dataRead.Length; i++)
            {
                string[] personInfo = dataRead[i].Split(";");
                //Console.WriteLine(personInfo[0]);
                File.AppendAllText("names.csv", personInfo[0] + "\n");
            }
        }
    }
}
