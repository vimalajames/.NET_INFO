using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50programs
{
    class important
    {
        //Check odd or Even
        public void odd()
        {
            Console.WriteLine("Check odd or Even");
            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }



            else
            {
                Console.WriteLine("The Number is odd");
            }
        }

        //Print odd no from 1 to 10.
        public void odd1()
        {

            Console.WriteLine("Print odd no from 1 to 10.");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);

            }
        }

        //print Even No from 1 to 500.
        public void even()
        {
            Console.WriteLine("print Even No from 1 to 500.");
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        //count odd number from 1 to 100;
        public void count()
        {
            Console.WriteLine("count odd number from 1 to 100;");
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 != 0)
                    count++;

            }
            Console.WriteLine(count);
        }
        //count Even No from 1to 150;
        public void count1()
        {
            Console.WriteLine("count Even No from 1to 150;");
            int count = 0;
            for (int i = 1; i <= 150; i++)
            {
                if (i % 2 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
        //Print Even sum from 1 to 10

        public void esum()
        {
            Console.WriteLine("Print Even sum from 1 to 10");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    sum = sum + i;
            }
            Console.WriteLine(sum);
        }

        //print odd sum from 1 to 90;
        public void odsum()
        {
            int sum =0;
            for (int i = 0; i <= 90; i++)

            {
                if (i % 2 != 0)
                    sum = sum + i;

            }
            Console.WriteLine(sum);
        }

        //Reverse the Given No:
        public void reverse()
        {
            Console.WriteLine("Reverse the Given No:");
            Console.WriteLine("Enter The No:");
            int no = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (no > 0)
            {
                int x = no % 10;
                result = (result * 10) + x;

                no = no / 10;

            }

            
            Console.WriteLine(result);
            Console.WriteLine("****************************\n");

        }
        //check polindrome no
        public void poly()
        {
            Console.WriteLine("check polindrome no");
            int no;
            Console.WriteLine("Enter the Number");
            no = Convert.ToInt32(Console.ReadLine());
            int temp = no;
            int result = 0;
            while (no > 0)
            {
                int x = no % 10;
                result = (result * 10) + x;
                no = no / 10;
            }
            Console.WriteLine("Result:" + result);
            if (temp == result)
            {
                Console.WriteLine("Given No is Polindrome");
            }
            else
            {
                Console.WriteLine("Not Polindrome");
            }

            Console.WriteLine("****************************\n");
        }

        //count no of digits
        public void nodigit()
        {
            Console.WriteLine("count no of digits");

            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (no > 0)
            {
                count++;
                no = no / 10;

            }
            Console.WriteLine(count);
            Console.WriteLine("****************************\n");
        }


        //Armstrong No
        public void arm()
        {
            Console.WriteLine("Armstrong No");
            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int temp = no;
            while (no > 0)
            {
                int x = no % 10;

                result = result + (x * x * x);
                no /= 10;


            }
            Console.WriteLine(result);
            if (temp == result)
            {
                Console.WriteLine("Armstrong No");
            }
            else
            {
                Console.WriteLine("Not Armstrong");
            }

            Console.WriteLine("****************************\n");
        }
        //sum of digits
        public void sumdigit()
        {
            Console.WriteLine("sum of digits");
            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (no > 0)
            {
                int x = no % 10;
                result = result + x;
                no /= 10;
            }
            Console.WriteLine("Sum of digit is:" + result);
            Console.WriteLine("****************************\n");
        }
        //swap two no with 3rd variable
        public void swap()
        {
            Console.WriteLine("swap two no with 3rd variable");
            int a = 10, b = 50;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("A value is:" + a);
            Console.WriteLine("B value is:" + b);

            Console.WriteLine("****************************\n");
        }

        // swap two No without 3 rd variable
        public void swap1()
        {
            Console.WriteLine("swap two No without 3 rd variable");
            int a = 30, b = 80;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("A value is:" + a);
            Console.WriteLine("B value is:" + b);
            Console.WriteLine("****************************\n");
        }
        //Factorial number
        public void factorial()
        {
            Console.WriteLine(" Finding Factorial value  ");
            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());
            int temp = no;
            int fact = 1;
            while (no > 0)
            {
                fact = fact * no;
                no = (no - 1);


            }
            Console.WriteLine("Factorial value of" + temp + "is:" + fact);
            Console.WriteLine("****************************\n");
        }
        //Prime no checking
        public void prime()
        {
            Console.WriteLine("Prime No Checking");
            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < no/2; i++)
            {

                if (no % i == 0)
                { 

                    count++;
                }
            }
                if (count == 0)
                {
                    Console.WriteLine("prime no");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            
                
            
            Console.WriteLine("****************************\n");
        }

        //Prime
        //nodisplay

        public void primedisplay()
        {
            Console.WriteLine("Prime No Display");

            Console.WriteLine("Enter the first No:");
            int fno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second No:");
            int sno = Convert.ToInt32(Console.ReadLine());

            for (int i = fno; i < sno; i++)

            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("Prime No is:" + i);

                }

            }

            Console.WriteLine("****************************\n");

        }


        //Reverse  the string

        public void reversstr()
        {
            Console.WriteLine("Reverse the string");
            Console.WriteLine("Enter the String:");
            String name = Console.ReadLine();


            string rev = "";

            int Namelength = name.Length;

            for (int i = Namelength - 1; i >= 0; i--)
            {
                rev += name[i].ToString();
            }

            Console.WriteLine(rev);
            Console.WriteLine("****************************\n");
        }



        //palindrome of a string

        public void polistr()
        {
            Console.WriteLine("palindrome of a string");
            Console.WriteLine("Enter The String:");
            string name = Console.ReadLine();
            string rev = "";
            int namelength = name.Length;

            for (int i = namelength - 1; i >= 0; i--)
            {
                rev = rev + name[i].ToString();

            }

            Console.WriteLine(rev);

            if (rev == name)
            {
                Console.WriteLine("The given String is polindrome");

            }
            else
            {
                Console.WriteLine("The given String is Not polindrome");
            }

            Console.WriteLine("****************************\n");
        }


        //ascending order in array
        public void arrascendign()
        {

            Console.WriteLine("ascending order in array");
            int[] ar = new int[5];

            ar[0] = 10;
            ar[1] = 250;
            ar[2] = 800;
            ar[3] = 470;
            ar[4] = 950;

            int length = ar.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (ar[i] > ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("****************************\n");

        }


        //descending order in array
        public void desarr()
        {
            Console.WriteLine("descending order in array");

            int[] ar = new int[5];
            ar[0] = 506;
            ar[1] = 256;
            ar[2] = 56;
            ar[3] = 6;
            ar[4] = 156;

            int length = ar.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (ar[i] < ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }

                }
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("****************************\n");

        }

        // maximum No in array
        public void maxarr()
        {

            Console.WriteLine("maximum No in array");
            Console.WriteLine("How many No's you have to Check:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the No:");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] < ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;

                    }
                }



            }
            Console.WriteLine("Maximum no  is:  " + ar[0]);

            Console.WriteLine("****************************\n");
        }
        //Minimum no in a array
        public void minarr()
        {
            Console.WriteLine("Minimum no in a array");
            Console.WriteLine("How many no you want to check:");
            int no = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[no];

            for (int i = 0; i < no; i++)
            {
                Console.WriteLine("Enter the No:");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < no; i++)
            {
                for (int j = i + 1; j < no; j++)
                {
                    if (ar[i] >ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            Console.WriteLine("Minimum No Is:"+ar[0]);
            Console.WriteLine("****************************\n");

        }

        //2 nd maximum no in Array
        public void maxar()
        {

            Console.WriteLine("2 nd maximum no in Array");
            int[] ar = new int[5];

            ar[0] = 8;
            ar[1] = 58;
            ar[2] = 158;
            ar[3] = 528;
            ar[4] = 588;

            int length = ar.Length;
            for(int i=0;i<length;i++)
            {
                for(int j=i+1;j<length;j++)
                {
                    if(ar[i]<ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
               
            }
            Console.WriteLine(ar[0]);
            Console.WriteLine("****************************\n");
        }


        // 3rd min value in array
        public void minar()
        {
            Console.WriteLine("3rd min value in array");
            int[] ar = new int[5];

            ar[0] = 998;
            ar[1] = 56;
            ar[2] = 1058;
            ar[3] = 5238;
            ar[4] = 588;

            int length = ar.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (ar[i] > ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }

            }
            Console.WriteLine(ar[3]);
            Console.WriteLine("****************************\n");
        }


        //remove the wowels from the string
        public  void remove_vowels()
        {

            string name = "vimala karolin  james sengole kabilan";
            Console.WriteLine("Given string is:"+name);

            string vow = "aeiouAEIOU";
            name = new string(name.Where(c => !vow.Contains(c)).ToArray());

            Console.WriteLine(name);
            Console.WriteLine("****************************\n");

        }
       
           
        public void remove_str()
        {
          /* string  name = "my name is vimala";
            string remove = "aeAE";
            int length = name.Length;
            int temp = 0;
            for(int i=0;i<length;i++)
            {
                foreach(char c in name)
                {
                    if (name.Contains(c)= !remove.Contains(c))
                    {
                        Console.WriteLine(name);
                    }
                }
            }*/

        }
        public void consonant()
        {
            string str = "my name is vimala";
            Console.WriteLine("Given string is:"+str);
            char[] ch = str.ToArray();
            int length = ch.Length;
            int count = 0;
            for(int i=0;i<length;i++)
            {
              char c = ch[i];
                if(c>='a'&&c<='z'||c>='A'&&c<='Z')
                {
                    if(!(c=='a'||c=='e'||c=='i'||c=='o'||c=='u'||c=='A'||c=='E'||c=='I'||c=='O'||c=='U'))
                    {
                        count++;
                    }
                }
           
            }
            Console.WriteLine("Consonant Count is :"+count);
            Console.WriteLine("****************************\n");
        }

        //Print Consonant value
        public void consonantvalue()
        {
            string str = "Rinson Anto James ";
            Console.WriteLine("Given string is:" + str);
            char[] ch = str.ToArray();
            int length = ch.Length;
            
            for (int i = 0; i < length; i++)
            {
                char c = ch[i];
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    if (!(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'))
                    {
                        Console.WriteLine(c);

                    }
                }
                
               
            }
            Console.WriteLine("****************************\n");
        }
        //Remove Duplicate value in array
        public void duplicate()
        {
            int[] arr1 = { 10, 20, 50, 20, 30, 10, 80 };
           // Console.WriteLine("Given value is:" + arr1);
            int[] arr2 = arr1.Distinct().ToArray();
            Console.WriteLine(  "After removing Duplicate:");
            Array.ForEach(arr2, i => Console.WriteLine(i));
            Console.WriteLine("****************************\n");

        }


        //Print vowelcount in a string
        public void vowcount()
        {
            int temp = 0;
            string name = "vimalakarolin";
            Console.WriteLine("Given string  is  :   "+name);
            int length = name.Length;
            //char[] ch = name.ToArray();
            string vow = "aeiouAEIOU";
            name = new string(name.Where(c => !vow.Contains(c)).ToArray());
            
            Console.Write("After remove vowels:"+name);
            int l2 = name.Length;
            temp = length - l2;
            Console.WriteLine("\n No of vowels :"+temp);
            Console.WriteLine("****************************\n");
        }


        //finding leap year
        public void leap()
        {
             int year;
             Console.Write("Enter the year : ");
             year = Convert.ToInt32(Console.ReadLine());
                       
           

                if (((year  % 4 == 0) || (year % 100 == 0) || (year % 400 == 0)))
                {
                    Console.WriteLine("Given year is leap year");

                }

                else
                {
                    Console.WriteLine("NOt leap year");
                }

            Console.WriteLine("*****************************\n");
        }

        //Fibonaci series

        public void fibo()
        {

            Console.Write("Enter the no to calculate fibonaci series   :  ");

            int no = Convert.ToInt32(Console.ReadLine());
            int a = 0,b=1,temp=0;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < no; i++)
            {
                temp = a+b;
                Console.WriteLine(temp);
                a = b;
                b = temp;
               
            }

            Console.WriteLine("****************************\n");
        }
    }
}
