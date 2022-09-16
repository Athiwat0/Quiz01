class Program //Bang Khun Thian
{
 public static void Main(string[] args)
 {
    
      
      string scoreText = InputScore();
      int scoreDecimal = ConvertStringToInt(scoreText);
      string grade = ConvertScoreToGrade(scoreDecimal);

 }

 public static int ConvertStringToInt(string value)
    {
        if (int.TryParse(value, out int number))
        {
            return number;
        }
        throw new Exception("Please input data.");
    }
        
    public static string ConvertScoreToGrade(int score)
    {
        if (score > 4)
        {
            throw new Exception("Please input decimal data.");
        }
        if (IsGradeA(score))
        {
            Info info = new Info();
            info.PrintInfoInformation();
        }
        else if (IsGradeBPlus(score))
        {
            Registrar registrar = new Registrar();
            registrar.PrintRegistrarInformation();

        }
        else if (IsGradeB(score))
        {
            Personnel personnel = new Personnel();
            personnel.PrintPersonnelInformation();
        }
        else if (IsGradeCPlus(score))
        {
             Personnel personnel = new Personnel();
             personnel.PrintPersonnelInformation();
        }
    }
    public static bool IsGradeA(int score)
    {
        return score ==1;
    }
    public static bool IsGradeBPlus(int score)
    {
        return score ==2;
    }
    public static bool IsGradeB(int score)
    {
        return score ==3;
    }
    public static bool IsGradeCPlus(int score)
    {
        return score ==4;
    }
    
 
   public static string InputScore()
   {
      Console.WriteLine("Store Information (A) ");
      Console.WriteLine("Company Founder (B) ");
      Console.WriteLine("");
      return Console.ReadLine();
   }

 
}