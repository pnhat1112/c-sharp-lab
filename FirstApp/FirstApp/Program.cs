using System;

namespace Exercise {

    class All {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("Welcome to Minh Nhat EXERCISES");
                Console.WriteLine("Choose EXERCISES");
                Console.WriteLine("1. EXERCISES 1");
                Console.WriteLine("2. EXERCISES 2");
                Console.WriteLine("3. EXERCISES 3");
                Console.WriteLine("4. EXERCISES 4");
                int chooseFunc = Convert.ToInt32(Console.ReadLine());
                if (chooseFunc > 4 || chooseFunc < 1) {
                    Console.WriteLine("Please re-Enter");
                    chooseFunc = Convert.ToInt32(Console.ReadLine());
                }
                else {
                    switch (chooseFunc) {

                        case 1:
                            Ex1();
                            break;

                        case 2:
                            Ex2();
                            break;

                        case 3:
                            Ex3();
                            break;

                        case 4:
                            Ex4();
                            break;
                    }
                }
            }
            
            
        }

        static void Ex1() {
            Console.WriteLine("Enter Number a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator:");
            char ope = Convert.ToChar(Console.ReadLine());
            if (ope == '+') {
                Console.WriteLine("Result: {0} + {1} = {2}", a, b, a + b);
            }
            else if (ope == '-')
                Console.WriteLine("Result: {0} - {1} = {2}", a, b, a - b);
            else if ((ope == 'x') || (ope == '*'))
                Console.WriteLine("Result: {0} * {1} = {2}", a, b, a * b);
            else if (ope == '/')
                Console.WriteLine("Result: {0} / {1} = {2}", a, b, a / b);
            else
                Console.WriteLine("Wrong Operator");
        }
        static void Ex2() {
            Console.WriteLine("Enter Number a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number c:");
            int c = Convert.ToInt32(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            double x, x1, x2; 
            
            if (delta > 0) {
                x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The Quadratic Equation has two roots are: " + x1 + ", " + x2);
            } else if(delta == 0) {
                x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The Quadratic Equation has one root is: " + x1);
            }  else {
                x1 = -b / (2 * a);
                x2 = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("Roots are: " + x1 + " ± " + x2 + "i");
            }   
        }
        static void Ex3() {

            Console.WriteLine("Please, Enter the Number to Check Prime: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int check = 0;
            if (a <= 2) {
                Console.WriteLine("Please re-Enter Number to Check Prime > 2");
                a = Convert.ToInt32(Console.ReadLine());
            } else {
                for (int i = 2; i <= a/2; i++) {
                    if (a % i == 0) {
                        Console.WriteLine("Your Number is not Prime.");
                        check = 1;
                        break;
                    }
                }
                if (check == 0) {
                    Console.WriteLine("Your Number is Prime.");
                }
            }
        }


        static void Ex4() {
            Random rnd = new Random();
            int randomNum = rnd.Next(1, 101);
            /*Console.WriteLine($"Number ramdom 1 to 100:{randomNum}");*/
            Boolean done = false;

            for (int i = 1; i < 8; i++) {
                Console.WriteLine("Chose Number You Want:");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select " + i + " Your Select Is: " + userNum);
                if (randomNum == userNum) {
                    Console.WriteLine("Done!! Nice, You Winner");
                    done = true;
                    break;

                }
                else if (randomNum > userNum) {
                    Console.WriteLine("Wrong! Random Number > Your Number: " + userNum);
                }
                else {
                    Console.WriteLine("Wrong! Random Number < Your Number: " + userNum);
                }
            }
            if (!done) {
                Console.WriteLine("You Lose!!!");
            }
        }
    }
}