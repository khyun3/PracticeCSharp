using System;
using CSharp.Properties;
using CSharp.소개;
using CSharp.유형;
using CSharp.프로그램_구성_요소;

namespace CSharp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string[] menu;
            var introduction = new Introduction();
            var type = new TypeMember();
            var programComponent = new ProgramComponent();
            do
            {
                menu = GetInput();
                switch (menu[0])
                {
                    case "1": //1. 소개
                        introduction.Select(menu[1]);
                        break;
                    case "2": //2. 유형
                        type.Select(menu[1]);
                        break;
                    case "3":
                        programComponent.Select(menu[1]);
                        break;
                    case "-1":
                        Console.WriteLine(Constants.PROGRAM_EXIT);
                        break;
                    default:
                        Console.WriteLine(Constants.MENU_IS_NOT_EXIST);
                        break;
                }

            } while (!menu[0].Equals("-1"));
        }

        private static string[] GetInput()
        {
            var input = Console.ReadLine();
            if (input != null)
            {
                if (input.Contains("-") && input.Length >= 3)
                {
                    string[] selectedMenu = input.Split(new[] { '-' });
                    return selectedMenu;
                }

                if (input.Equals("-1"))
                {
                    return new[] { "-1", "0" };
                }
            }

            return new[] { "0", "0" };
        }
    }
}