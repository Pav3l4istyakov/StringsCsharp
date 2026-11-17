namespace StringsCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение\n");
            string UserInput = Console.ReadLine();
            string Result = "";
            bool BigLetter = true;
            UserInput = UserInput.Trim();
            for (int i = 0; i < UserInput.Length; i++)
            {
                char AnySymvol = UserInput[i];
                if (char.IsWhiteSpace(AnySymvol))
                {
                    Result += AnySymvol;
                    BigLetter = true;
                }
                else if (BigLetter == true)
                {
                    Result += Char.ToUpper(AnySymvol);
                    BigLetter = false;
                }
                else
                {
                    Result += Char.ToLower(AnySymvol);

                }
            }

            if (string.IsNullOrEmpty(UserInput))
            {
                Console.WriteLine("Пустая строка\n");
                return;
            }
            if (Result[Result.Length - 1] != '.')
            {
                Result += ".";
            }
            Console.WriteLine(Result);
            
            

        }
    }
}
