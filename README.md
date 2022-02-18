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
