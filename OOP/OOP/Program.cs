using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to Minh Nhat EXERCISES OOP");
            Console.WriteLine("Choose EXERCISES");
            Console.WriteLine("1. EXERCISES 1: Dice");
            Console.WriteLine("2. EXERCISES 2: Student");
            Console.WriteLine("3. EXERCISES 3: Song");
            Console.WriteLine("4. EXERCISES 4: Fraction");
            int chooseFunc = Convert.ToInt32(Console.ReadLine());
            if (chooseFunc > 4 || chooseFunc < 1)
            {
                Console.WriteLine("Please re-Enter");
                chooseFunc = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                switch (chooseFunc)
                {

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

        static void Ex1()
        {

            Dice dice = new Dice();
            Console.WriteLine("Enter the slides of the dice: ");
            dice.SidesCount = Convert.ToInt32(Console.ReadLine());
            
            if (dice.SidesCount < 6)
            {
                Console.WriteLine("re-Enter the slides of the dice >= 6: ");
                dice.SidesCount = Convert.ToInt32(Console.ReadLine());
            }
            
            while (true)
            {
                Console.WriteLine("Enter the number of the dice: ");
                int userDice = Convert.ToInt32(Console.ReadLine());
                int slide = dice.RollDice();
                /*Console.WriteLine(slide);*/
                if (userDice == slide)
                {
                    Console.WriteLine("You Win!!! ");
                    Console.WriteLine("Your Number is: " + userDice);
                    Console.WriteLine("Dice Number is: " + slide);
                    break;
                }
                else
                {
                    Console.WriteLine("You Wrong!!! ");
                    Console.WriteLine("Your Number is: " + userDice);
                    Console.WriteLine("Dice Number is: " + slide);
                }
            }
        }
        static void Ex2()
        {

            
            Student student = new Student();
            student.InputStudent();
            student.DisplayStudent();
        }
        static void Ex3()
        {
            Console.WriteLine("Enter the Number of Song");
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numSongs; i++)
            {
                Console.WriteLine("Enter the Informations of Song: Example: Classic_SomeThingJustLikeThis_3:20");
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            Console.WriteLine("Enter the Type List: ");
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                Console.WriteLine("All Songs of Your Type List: ");
                foreach (Song s in songs)
                {
                    Console.WriteLine(s.Name);
                }
            }
            else
            {
                Console.WriteLine("Songs of Your Type List: " + typeList);
                foreach (Song s in songs)
                {
                    if (s.TypeList == typeList)
                    {
                        Console.WriteLine(s.Name);
                    }
                }
            }
            /*List<Song> filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();
            foreach(Song song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }*/

        }
        static void Ex4()
        {
            int choose;
            while (true)
            {
                Console.WriteLine("Welcome to Minh Nhat Fractions");
                Console.WriteLine("0. Input two fractions and display in normalize form.");
                Console.WriteLine("1. Add two fractions.");
                Console.WriteLine("2. Subtract two fractions.");
                Console.WriteLine("3. Multiply two fractions.");
                Console.WriteLine("4. Divide two fractions.");
                Console.WriteLine("5. Display a fraction in form (A/B).");
                Console.WriteLine("6. Display a fraction on the screen as a decimal number.");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Type your choice:");
                choose = int.Parse(Console.ReadLine());
                if (choose == 7)
                {
                    break;
                }
                Fraction frac = new Fraction();
                switch (choose)
                {
                    case 0:
                        Console.WriteLine("Enter the fisrt fraction");
                        Fraction frac1 = new Fraction();
                        frac1.Input();
                        Console.WriteLine("Enter the second fraction");
                        Fraction fr2 = new Fraction();
                        fr2.Input();
                        frac1.normalize();
                        fr2.normalize();
                        Console.WriteLine($"Fisrt fraction is: {frac1.ToString()}, Second fraction is: {fr2.ToString()}");
                        break;
                    case 1:
                        frac = addFrtn();
                        frac.normalize();
                        System.Console.WriteLine($"{frac.ToString()}");
                        break;
                    case 2:
                        frac = minusFrtn();
                        frac.normalize();
                        System.Console.WriteLine($"{frac.ToString()}");
                        break;
                    case 3:
                        frac = multiFrtn();
                        frac.normalize();
                        Console.WriteLine($"{frac.ToString()}");
                        break;
                    case 4:
                        frac = divFrtn();
                        frac.normalize();
                        Console.WriteLine($"{frac.ToString()}");
                        break;
                    case 5:
                        Console.WriteLine("Enter Your Fraction: ");
                        frac.Input();
                        Console.WriteLine($"{frac.ShowAB()}");
                        break;
                    case 6:
                        Console.WriteLine("Enter Your Fraction: ");
                        frac.Input();
                        Console.WriteLine($"{frac.ToDouble()}");
                        break;
                    default:
                        break;
                }
                System.Console.WriteLine("Enter to continue");
                Console.ReadKey();
            }
            static Fraction addFrtn()
            {
                System.Console.WriteLine("Enter the fisrt fraction");
                Fraction fr = new Fraction();
                fr.Input();
                System.Console.WriteLine("Enter the second fraction");
                Fraction fr2 = new Fraction();
                fr2.Input();
                return fr.add(fr2);
            }
            static Fraction minusFrtn()
            {
                System.Console.WriteLine("Enter the fisrt fraction");
                Fraction fr = new Fraction();
                fr.Input();
                System.Console.WriteLine("Enter the second fraction");
                Fraction fr2 = new Fraction();
                fr2.Input();
                return fr.minus(fr2);
            }
            static Fraction multiFrtn()
            {
                System.Console.WriteLine("Enter the fisrt fraction");
                Fraction fr = new Fraction();
                fr.Input();
                System.Console.WriteLine("Enter the second fraction");
                Fraction fr2 = new Fraction();
                fr2.Input();
                return fr.multi(fr2);
            }
            static Fraction divFrtn()
            {
                System.Console.WriteLine("Enter the fisrt fraction");
                Fraction fr = new Fraction();
                fr.Input();
                System.Console.WriteLine("Enter the second fraction");
                Fraction fr2 = new Fraction();
                fr2.Input();
                return fr.divide(fr2);
            }

        }
    }
}

class Dice
{
    private int sidesCount;
    public int SidesCount
    {
        get
        {
            return sidesCount;
        }
        set
        {
            sidesCount = value;
        }
    }

    public int RollDice()
    {
        Random random = new Random();
        return random.Next(SidesCount) + 1;
    }
}

class Person
{
    protected string name;
    protected int age;
    public int Age
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                age = value;
            } else
            {
                Console.WriteLine("re-Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }
        }
        get { return age; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public void DisplayPerson()
    {
        Console.WriteLine("Name Person is: " + name);
        Console.WriteLine("Age Person is: " + age);
    }
    public void InputPerson()
    {

        Console.WriteLine("Enter name:");
        Name = Console.ReadLine();
        Console.WriteLine("Enter age:");
        Age = Convert.ToInt16(Console.ReadLine());

    }
    public Person()
    {
    }
    /*public toString()
    {

    }*/
}

class Student : Person
{
    protected double gpa;
    public double Gpa
    {
        get { return gpa; }
        set { gpa = value; }
    }
    
    public Student()
    {
    }
    public void InputStudent()
    {
        base.InputPerson();
        Console.WriteLine("Enter GPA:");
        Gpa = Convert.ToDouble(Console.ReadLine());

    }
    public void DisplayStudent()
    {
        Console.WriteLine("Name Student is: " + name);
        Console.WriteLine("Age Student is: " + age);
        Console.WriteLine("GPA Student is: " + gpa);
    }
}

class Song
{
    private string typeList;
    private string name;
    private string time;

    public string TypeList
    {
        get { return typeList; }
        set
        {
            typeList = value;
        }
    }
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }
    public string Time
    {
        get { return time; }
        set
        {
            time = value;
        }
    }
    public static Song addedSong()
    {
        string[] data = Console.ReadLine().Split("_");
        Song song = new Song();

        song.TypeList = data[0];
        song.Name = data[1];
        song.Time = data[2];
        return song;

    }

}

class Fraction {
    private long a;
    private long b;
    public long A
    {
        get { return a; }
        set { a = value; }
    }
    public long B
    {
        get { return b; }
        set { b = value; }
    }
    public void DisplayFraction()
    {
        Console.WriteLine("Your Fraction is: " + A + "/" + B);
    }
    public void Input()
    {
        Fraction fraction = new Fraction();
        string[] data = Console.ReadLine().Split("/");
        A = Convert.ToInt32(data[0]);
        B = Convert.ToInt32(data[1]);
    }
    
    public void normalize()
    {
        long gcd = GCD(A, B);
        A = A / gcd;
        B = B / gcd;
    }

    public static long GCD(long a, long b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }

    public string ToString()
    {
        if (A % B == 0)
        {
            return $"-> {A / B}";
        }
        else
            return $"-> {A}/{B}";
    }
    public string ShowAB()
    {
        if (A % B == 0)
        {
            return $"-> {A / B}" + "| A is: " + A + "| B is: " + B;
        }
        else
            return $"-> {A}/{B}" + "| A is: " + A + "| B is: " + B;
    }
    
    public string ToDouble()
    {
        return "-> " + (double)A / (double)B;
    }
    public Fraction(long valuea, long valueb)
    {
        a = valuea;
        b = valueb;
    }
    public Fraction()
    {
    }
    private void multBy(long x)
    {
        A = A * x;
        B = B * x;
    }
    public Fraction add(Fraction scd)
    {
        long ta = B;
        long tb = scd.B;
        scd.multBy(ta);
        multBy(tb);
        return new Fraction(A + scd.A, B);
    }
    public Fraction minus(Fraction scd)
    {
        long ta = B;
        long tb = scd.B;
        scd.multBy(ta);
        multBy(tb);
        return new Fraction(A - scd.A, B);
    }
    public Fraction multi(Fraction scd)
    {
        return new Fraction(A * scd.A, B * scd.B);
    }
    public Fraction divide(Fraction scd)
    {
        return new Fraction(A * scd.B, B * scd.A);
    }

    public static String DecimalToFraction(double dec)
    {
        string str = dec.ToString();
        if (str.Contains('.'))
        {
            String[] parts = str.Split('.');
            long whole = long.Parse(parts[0]);
            long numerator = long.Parse(parts[1]);
            long denominator = (long)Math.Pow(10, parts[1].Length);
            long divisor = GCD(numerator, denominator);
            long num = numerator / divisor;
            long den = denominator / divisor;

            String fraction = num + "/" + den;
            if (whole > 0)
            {
                return whole + " " + fraction;
            }
            else
            {
                return fraction;
            }
        }
        else
        {
            return str;
        }
    }
}