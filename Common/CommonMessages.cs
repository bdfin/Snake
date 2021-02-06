using System;

namespace Snake.Common
{
    public class CommonMessages
    {
        public static void Continue()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine(CommonMessageConstants.Continue);
            Console.ReadKey();
        }
    }
}
