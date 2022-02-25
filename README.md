# keeruthi
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
 output :  ![image](https://user-images.githubusercontent.com/97940146/154633856-c7a9f826-bb02-4f37-b444-6f0e562224d1.png)

1> c# program to print a binary triangle

using System;

namespace ConsoleApp4
{
    class BinaryTriangle 
    {
        static void main(string[] args)
         {
        int number, digit = 1;
        Console.Write("\n Enter the number of lines:");
        number = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=number;i++)
        {
            for(int space=number-i;space>0;space--)
            {
                Console.Write("");
            }
            for(int j=0;j<i;j++)
            {
                Console.Write(digit + "");
                digit = (digit == 1) ? 0 : 1;
            }
            Console.Write("\n");
        }
        }
    }
}
output :![image](https://user-images.githubusercontent.com/97940146/154634513-6641521f-45b3-4246-9e9f-47a13c8e1e5a.png)
----------------------------------------------------------------------------------------------------------------------------------------------------------------------
2> c# program to check whether the entered number is an Amicable Number or not

 using System;

namespace ConsoleApp5
{
    class AmicableNumber
    {
        static void Main(string[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0;
            Console.WriteLine("\n----------AMICABLE NUMBERS--------\n");
            Console.Write("\n Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<num2;i++)
            {
                if(num1%i==0)
                {
                    sum1 += i;
                }
            }
        for(int i=1;i<num2;i++)
            {
                if(num2%i==0)
                {
                    sum2 += i;
                }
            }
        if(sum1==num2&&sum2==num1)
            {
                Console.WriteLine("\n The numbers {0} and {1} dre amiciable", num1, num2);
            }
        else
            {
                Console.WriteLine("\n The number {0} and {1} are not amiciable", num1, num2);
            }
                }
    }
}

output : ![image](https://user-images.githubusercontent.com/97940146/154636028-d582561f-714f-4aba-94d1-bb67d26c63f6.png)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
3> c# program to illustrate multilevel inheritance with virtual methods(display student detail)

using System;

namespace ConsoleApp6
{
    class PersonalDetails 
    {
        string name;
        int age;
        string gender;
        public PersonalDetails(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n--------- PERSONAL DETAILS--------\n");
            Console.WriteLine("Name         :" + name);
            Console.WriteLine("Age       :" + age);
            Console.WriteLine("Gender         :" + gender);
        }
    }
    class CourseDetails:PersonalDetails
    { 
        int regNo;
        string course;
        int semester;
        public CourseDetails(string name, int age, string gender, int regNo, string course, int semester) : base(name, age, gender)
    {
        this.regNo = regNo;
        this.course = course;
        this.semester = semester;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("\n--------------COURSE DETAILS-----------\n");
        Console.WriteLine("Register number        :", +regNo);
        Console.WriteLine("Course        :" +course);
        Console.WriteLine("Semester       :", +semester);
    }
}
 class MarksDetails:CourseDetails
{
    int[] marks = new int[5];
    int total;
    float average;
    string grade;
    int flagFail;
    public MarksDetails(string name,int age,string gender,int regNo,string course,int semester,int[] marks):base(name,age,gender,regNo,course,semester)
    {
        total = 0;
        for(int i=0;i<5;i++)
        {
            this.marks[i] = marks[i];
            total += marks[i];
            if(marks[i]<35)
            {
                flagFail = 1;
            }
        }
        Calculate();
    }
    private void Calculate()
    {
        average = total / 5;
        if (flagFail == 1 || average < 40)
            grade = "Fail";
        else if (average >= 70)
            grade = "Distinction";
        else if (average > 60)
            grade = "First class";
        else if (average > 50)
            grade = "second class";
        else
            grade = "pass class";
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("\n ----------MARKS DETAILS--------\n");
        Console.Write("marks in 5 subjects:");
        for (int i = 0; i < 5; i++)
            Console.Write(marks[i] + " ");
        Console.WriteLine();
        Console.WriteLine("Total      :" + total);
        Console.WriteLine("Average       :" + average);
        Console.WriteLine("Grade         :" + grade);
    }
}
class MultiLevel
{
    public static void Main(string[]args)
    {
        MarksDetails student1 = new MarksDetails("Abhijith", 22, "Male", 20190001, "MCA", 5, new int[] { 77, 80, 98, 95, 90 });
            student1.Display();
    }
}
}

output :![image](https://user-images.githubusercontent.com/97940146/154636686-5e114600-3429-4c8e-a569-876435c7f44c.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
4> c# program to generate Gray codeof decimal number

using System;

namespace Exercise 
{
    class GrayCode 
    {
        static int getGray(int n) 
        {
            return n ^ (n >> 1);
        } 
        static void main(string[]args)  
        {
            int InputNum, GrayNum;
            Console.Write("\n Enter the decimal number:");
            InputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Binary equivalent of {0}:{1}", InputNum, Convert.ToString(InputNum, 2));
            GrayNum = getGray(InputNum);  
            Console.WriteLine("\n Gray code equivalent of {0}:{1}", InputNum, Convert.ToString(GrayNum, 2));
        }
    }
}

output :![image](https://user-images.githubusercontent.com/97940146/154637209-6ebd7e91-610c-4077-add5-baa1977b0902.png)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
5> c# program to calculate volume of 2 boxes and find the resultant volume after addition of 2 boxes bu implementing operator overloading

using System;

namespace Exercise 
{
    class Box
    {
        float width;
        float height;
        float length;
        public float Volume
        {
            get { return width * height * length; }
        }
        public Box(float width,float height,float length)
        {
            this.width = width; 
            this.height = height;
            this.length = length;
        }
        public static float operator+(Box box1,Box box2)
        {
            return box1.Volume + box2.Volume;

        }
        public override string ToString()
        {
            return "box with width" + width + ",height" + height + "and length" + length;

        }
        class OperatorOverloading
        {
            public static void main()
            {
                Box box1 = new Box(10, 20, 30);
                Box box2 = new Box(25, 32, 15);
                Console.WriteLine("Volume of {0}is:{1}", box1, box1.Volume);
                Console.WriteLine("Volume of {0}is:{1}", box2, box2.Volume);
                Console.WriteLine("Vloume after adding boxes:{0}", box1 + box2);
            }
        }
    }
}

Output : ![image](https://user-images.githubusercontent.com/97940146/155665064-dcc06aaf-fb44-4c7d-826c-1654dc69b92b.png)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
6> C# program to implement principles of Delegates(converting input string to uppercase first,last and entire string)

using System;
namespace Exercises
{
    class Delegates
    {
        delegate string UppercaseDelegate(string input);
        static string UppercaseFirst(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[0] = char.ToUpper(buffer[0]);
            return new string(buffer);
        }
        static string UppercaseLast(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]); return new string(buffer);
        }
        static string UppercaseAll(string input)
        {
            return input.ToUpper();
        }
        static void WriteOutput(string input, UppercaseDelegate del)
        {
            Console.WriteLine("Input String: {0}", input);
            Console.WriteLine("Output String: {0}", del(input));
        }
        static void main() 
        {
            WriteOutput("tom ", new UppercaseDelegate(UppercaseFirst));
            WriteOutput("tom", new UppercaseDelegate(UppercaseLast));
            WriteOutput("tom", new UppercaseDelegate(UppercaseAll));
            Console.ReadLine();
        }
    }
}

Output : ![image](https://user-images.githubusercontent.com/97940146/155665637-a053a1bb-1327-44f8-b8c7-4a73fdb47243.png)
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

7>C# program to generate Register Number automatically for 100 student using static constructor
using System;

namespace Exercises 
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
        public static void main(string[]args)
        {
            for(int i=0;i<100;i++)
            {
                RegisterNum student = new RegisterNum();
                Console.WriteLine("student{0} : {1}", i + 1, student.regNo);
            }
        }
    }
}
Output : [image](https://user-images.githubusercontent.com/97940146/155666316-26339e46-dd63-4b32-b508-631315106c71.png)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
