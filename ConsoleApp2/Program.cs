using MyNamespace.model;

namespace MyNamespace
{
   

    class Program
    {
        static void Main(string[] args)
        {
            // Coords coords = new Coords(2, 3);
            // // Do something with the coords
            // Console.WriteLine(coords);
            // var name = "fariz";
            // Console.WriteLine(name);
            // Mybio mybioData = new Mybio("fariz", 21, "male");
            // Console.WriteLine(mybioData);
            // make a standard clalculator 
            double num1, num2, result;
            char op;
            Console.Write("masukkan angka: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("enter operation (+,-,x,/) :");
            op = char.Parse(Console.ReadLine());
            Console.Write("enter num :");
            num2 = double.Parse(Console.ReadLine());
            
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine(num1 + "+" + num2 + '=' + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine(num1 + "-" + num2 + '=' + result);
                    break;
                case 'x':
                    result = num1 * num2;
                    Console.WriteLine(num1 + "x" + num2 + '=' + result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine(num1 + "/" + num2 + '=' + result);
                    break;
                default:
                    Console.WriteLine("Unknown operation!");
                    break;
            }

            int noCar = 12;
            Console.WriteLine(Convert.ToString(noCar));
            Console.WriteLine($"nocar : {noCar.GetType}");

            string name =
                "Krung Thep Mahanakhon Amon Rattanakosin Mahinthara Yuthaya Mahadilok Phop Noppharat Ratchathani Burirom Udomratchaniwet Mahasathan Amon Piman Awatan Sathit Sakkathattiya Witsanukam Prasit";
            Console.WriteLine("lenght of name is " + name.Length);
            Console.WriteLine(name[2]);
            string myOshi = "vinisa yustiara";
            int indexNamaBelakang = myOshi.IndexOf("y");
            string namaBelakang = myOshi.Substring(indexNamaBelakang);
            Console.WriteLine($"nama belakang dari {myOshi} adalah {namaBelakang}");
        }
    }
}
