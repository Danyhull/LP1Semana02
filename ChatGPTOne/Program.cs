using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            string question, response;
            bool exit = true;

            //pergunta ao user
            while (exit == true){
                Console.Write("Place your question? ");
                question = Console.ReadLine();

            // Respostas as perguntas
                switch (question)
                {
                    case "EXIT":
                        response = "";
                        exit = false;
                        break;
                    case "Who are you?":
                        response = "I`m Zé Castelo Branco!";
                        break;
                    case "How can i be better in school?":
                        response = "Use more ChatGPT but be careful!";
                        break;
                    case "Where do u live?":
                        response = "I don't live in Amadora!";
                        break;
                    case "How can i be intelligent like you?":
                        response = "U can't!";
                        break;
                    default:
                        response = "I'am sorry but that question i can't answer";
                        break;
                }

                // Responde adequadamente
                Console.WriteLine(response);
        }
    }
}
