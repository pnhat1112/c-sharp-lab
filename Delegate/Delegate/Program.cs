public class Program
{
    static void Main(string[] args)
    {
        TestCal();
        FuncAction func = new FuncAction();
        Console.WriteLine("Func trong Delegate:");
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ket qua ham Func:");
        func.TestFunc(a, b);

    }
    public delegate void Calculation(string s);

    static public void Sum(string s)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(string.Format("{0} ", s));
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Format("Tong 2 so: {0} va {1} la: {2}", a, b, a+b));
        Console.ResetColor();
    }

    static public void Minus(string s)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(string.Format("{0} ", s));
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Format("Tong 2 so: {0} va {1} la: {2}", a, b, a - b));
        Console.ResetColor();
    }

    public static void TestCal()
    {
        Calculation cal;

        cal = Sum;
        cal("Tinh Tong");

        cal = Minus;
        cal("Phep tru");
    }
    public class FuncAction
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        public void TestFunc(int x, int y)
        {
            Func<int, int, int> tinhtong;
            tinhtong = Sum;

            var ketqua = tinhtong(x, y);
            Console.WriteLine(ketqua);
        }
    }
}