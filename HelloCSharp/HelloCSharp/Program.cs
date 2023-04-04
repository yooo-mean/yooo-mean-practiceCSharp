using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //매개변수가 없을 경우
            if (args.Length < 1) Console.WriteLine("Hello! CSharp!");
            //매개변수가 있을 경우
            else
            {
                Console.Write("Hello! ");
                //매개변수를 모두 나열
                for(int i = 0; i < args.Length; i++) {
                    if (i != args.Length - 1) Console.Write(args[i] + ", ");
                    //마지막 매개변수는 !와 함께 마무리
                    else Console.WriteLine(args[i] + "!");
                }
            }
            Console.WriteLine("매개변수로 전달 된 문자열 수 : " + args.Length);
            Console.Write("아무 키나 누를 시 종료");
            Console.ReadKey();
        }
    }
}
