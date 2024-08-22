namespace MyNamespace.switchLearn;

public class FunctionMenghitungNilaiRaport 
{
    public static string nilaiRaport(int nilai)
    {
        switch (nilai)
        {
            case 0:
                return "you not pass";
                break;
            case >= 50 and <= 70:
                return "you pass, but not good enough";
                break;
            case >= 70 and <= 80:
                return "you pass and good job!";
                // Console.WriteLine("you pass and good job!");
                break;
            case >85 and <= 100:
                return "you pass and excelent job!";
                // Console.WriteLine("you pass and excellent job!");
            default:
                return "invalid score";
            
        }
        
    }
}