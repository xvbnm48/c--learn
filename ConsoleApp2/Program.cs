using MyNamespace.model;
using MyNamespace.ternary;
using MyNamespace.while_loop;

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
            // double num1, num2, result;
            // char op;
            // Console.Write("masukkan angka: ");
            // num1 = double.Parse(Console.ReadLine());
            // Console.Write("enter operation (+,-,x,/) :");
            // op = char.Parse(Console.ReadLine());
            // Console.Write("enter num :");
            // num2 = double.Parse(Console.ReadLine());
            
            // switch (op)
            // {
            //     case '+':
            //         result = num1 + num2;
            //         Console.WriteLine(num1 + "+" + num2 + '=' + result);
            //         break;
            //     case '-':
            //         result = num1 - num2;
            //         Console.WriteLine(num1 + "-" + num2 + '=' + result);
            //         break;
            //     case 'x':
            //         result = num1 * num2;
            //         Console.WriteLine(num1 + "x" + num2 + '=' + result);
            //         break;
            //     case '/':
            //         result = num1 / num2;
            //         Console.WriteLine(num1 + "/" + num2 + '=' + result);
            //         break;
            //     default:
            //         Console.WriteLine("Unknown operation!");
            //         break;
            // }

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
            bool isAdmin = true;
            bool isStudent = true;
            if (isAdmin && isStudent)
            {
                Console.WriteLine("you are a admin and student");
            }else if (!isAdmin || isStudent)
            {
                Console.WriteLine("you are a student");
            } else if (!isStudent)
            {
                Console.WriteLine("you are not a student");
            }
            else
            {
                Console.WriteLine("you are not a admin");
            }
            int []number_list = {1,2,3,4,5,6,7,8,9,10};
            int largestNumber = number_list[0];
            for (int i = 1; i < number_list.Length; i++)
            {
                if (number_list[i] > largestNumber)
                {
                    largestNumber = number_list[i];
                }
            }
            Console.WriteLine($"the largest numberis a {largestNumber}");
            Kucing kucingku = new Kucing();
            kucingku.Mengeong();
            kucingku.Makan();
            string tegami =
                "vini adalah seorang idol dari Hira dazzle, dia itu member hira dazzle emerald green. Dia sangat cantik dan imut itu sangat ku suka, sangat \"suka\"";
            Console.WriteLine(tegami);
            Ternary isOld = new Ternary();
            Console.WriteLine(isOld.result);
            string resultSwitch = switchLearn.FunctionMenghitungNilaiRaport.nilaiRaport(89);
            Console.WriteLine(resultSwitch);
            whileLearn.belajarWhile(5);
            perwarisan.Person learnPerwarisan = new perwarisan.Person();
            // learnPerwarisan.Name = "fariz love vini";
            // kalau di atas ini langsung ganti ke struct 
            // kalau dibawah ini itu akses ke function change name untuk ganti struct nya 
            learnPerwarisan.ChangeName("fariz love vini");
            Console.WriteLine(learnPerwarisan.Name);
        }
    }

    class Hewan
    {
        public void Makan()
        {
            Console.WriteLine("Makan");
        }
    }

    class Kucing : Hewan
    {
        public void Mengeong()
        {
            Console.WriteLine("Mengeong");
        }
 
    }
    
}
