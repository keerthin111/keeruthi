using System;

namespace ConsoleApp10
{
    class RegisterNum
    {
        int regNo;
        static int startNum;
        static RegisterNum()
        {
            startNum = 20210000;
        }
        RegisterNum()
        {
            regNo = ++startNum;

        }
        public static void Main(string[]args)
        {
            for(int i=0;i<100;i++)
            {
                RegisterNum student = new RegisterNum();
                Console.WriteLine("student{0} : {1}", i + 1, student.regNo);
            }
        }
    }
}
