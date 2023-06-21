using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization;

class Prgogram
{
    static void Main(string[] args)
    {
        AccountList accList = new AccountList();
        while (true)
        {
            Console.WriteLine("Welcome to Minh Nhat EXERCISES BANKS");
            Console.WriteLine("1.Add Account");
            Console.WriteLine("2 Display List Account");
            Console.WriteLine("3.Save File");
            Console.WriteLine("4.Load File");
            Console.WriteLine("5.Remove Account");
            Console.WriteLine("6.Sort List by Account ID");
            Console.WriteLine("7.Sort List by Frist Name");
            Console.WriteLine("8.Sort List by Last Name");
            Console.WriteLine("9.Sort List by Balance");
            Console.WriteLine("10.Serialization List");
            Console.WriteLine("11.DeSerialization List");
            int chooseFunc = Convert.ToInt32(Console.ReadLine());
            if (chooseFunc > 11 || chooseFunc < 1)
            {
                Console.WriteLine("Please re-Enter Function");
                chooseFunc = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                switch (chooseFunc)
                {
                    case 1:
                        accList.NewAccount();
                        break;
                    case 2:
                        accList.DisplayList();
                        break;
                    case 3:
                        accList.SaveFile();
                        break;
                    case 4:
                        accList.LoadFile();
                        break;
                    case 5:
                        accList.RemoveAccount();
                        break;
                    case 6:
                        List<Account> listSortID = new List<Account>();
                        listSortID = accList.GetListAccount();
                        AccountCompare compareID = new AccountCompare();
                        compareID.compareByFields = AccountCompare.sortBy.accountID;
                        /*Console.WriteLine(compareID);
                        Console.WriteLine(AccountCompare.sortBy.accountID);
                        Console.WriteLine(compareID.compareByFields);*/
                        listSortID.Sort(compareID);
                        /*foreach (Account a in listSortID)
                        {
                            Console.WriteLine(a.FirstName);
                        }*/
                        Console.WriteLine("Sort by Accout ID");
                        foreach (Account emp in listSortID)
                        {
                            Console.WriteLine("Account ID: " + emp.GetAccountID() + " | First Name: " + emp.GetFirstName() + " | Last Name: " + emp.GetLastName() +
                                " | Balance: " + emp.GetBalance());
                        }
                        break;
                    case 7:
                        List<Account> listSortFirstName = new List<Account>();
                        listSortFirstName = accList.GetListAccount();

                        AccountCompare compareFirstName = new AccountCompare();
                        compareFirstName.compareByFields = AccountCompare.sortBy.firstName;
                        listSortFirstName.Sort(compareFirstName);
                        Console.WriteLine("Sort by First Name");
                        foreach (Account emp in listSortFirstName)
                        {
                            Console.WriteLine("Account ID: " + emp.GetAccountID() + " | First Name: " + emp.GetFirstName() + " | Last Name: " + emp.GetLastName() +
                                " | Balance: " + emp.GetBalance());
                        }
                        break;
                    case 8:
                        List<Account> listSortLastName = new List<Account>();
                        listSortLastName = accList.GetListAccount();

                        AccountCompare compareLastName = new AccountCompare();
                        compareLastName.compareByFields = AccountCompare.sortBy.lastName;
                        listSortLastName.Sort(compareLastName);
                        Console.WriteLine("Sort by Last Name");
                        foreach (Account emp in listSortLastName)
                        {
                            Console.WriteLine("Account ID: " + emp.GetAccountID() + " | First Name: " + emp.GetFirstName() + " | Last Name: " + emp.GetLastName() +
                                " | Balance: " + emp.GetBalance());
                        }
                        break;
                    case 9:
                        List<Account> listSortBalance = new List<Account>();
                        listSortBalance = accList.GetListAccount();

                        AccountCompare compareBalance = new AccountCompare();
                        compareBalance.compareByFields = AccountCompare.sortBy.balance;
                        listSortBalance.Sort(compareBalance);
                        Console.WriteLine("Sort by Balance");
                        foreach (Account emp in listSortBalance)
                        {
                            Console.WriteLine("Account ID: " + emp.GetAccountID() + " | First Name: " + emp.GetFirstName() + " | Last Name: " + emp.GetLastName() +
                                " | Balance: " + emp.GetBalance());
                        }
                        break;
                    case 10:
                        /*IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("D:\\Learning\\VKU\\Năm 4 Kì 1\\Windows\\Project\\Banks\\Account.data", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, accList);
                        stream.Close();*/
                        List<Account> listSer = new List<Account>();
                        listSer = accList.GetListAccount();
                        Console.Write("Enter file's name: ");
                        string filename = "data/" + Console.ReadLine() + ".bin";
                        FileStream s = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter reader = new StreamWriter(s);
                        BinaryFormatter b = new BinaryFormatter();
                        b.Serialize(s, listSer);
                        s.Close();
                        Console.WriteLine($"Saved in {filename}");
                        break;
                    case 11:
                        List<Account> listDeser = new List<Account>();
                        listDeser = accList.GetListAccount();
                        System.Console.Write("Enter file's name: ");
                        string filenamede = "data/" + Console.ReadLine() + ".bin";
                        FileStream s1 = new FileStream(filenamede, FileMode.Open, FileAccess.Read);
                        StreamReader reader1 = new StreamReader(s1);
                        BinaryFormatter b1 = new BinaryFormatter();
                        listDeser = (List<Account>)b1.Deserialize(s1);
                        s1.Close();
                        break;
                }
            }
            /*void DeSerialize()
            {
                System.Console.Write("Enter file's name: ");
                string filename = "data/" + Console.ReadLine() + ".bin";
                FileStream s = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(s);
                BinaryFormatter b = new BinaryFormatter();
                accList = (List<Account>)b.Deserialize(s);
                s.Close();
            }*/
        }
    }
    public class Account 
    {
        public string AccountID;
        public string FirstName;
        public string LastName;
        public double Balance;
        /*public string AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }*/

        public string GetAccountID()
        {
            return AccountID;
        }

        public void SetBookName(string accountID)
        {
            this.AccountID = accountID;
        }
        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }
        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }
        public double GetBalance()
        {
            return Balance;
        }

        public void SetBalance(double balance)
        {
            this.Balance = balance;
        }
        public Account() { }
        public Account(string accountID, string firstName, string lastName, double balance)
        {
            AccountID = accountID;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }
        public Account(string accountID) {
            if (string.IsNullOrWhiteSpace(accountID))
                throw new ArgumentException("accountID");
            AccountID = accountID;
        }
        public void FillInfor()
        {
            Console.WriteLine("Enter Account ID: ");
            AccountID = Console.ReadLine();
            Console.WriteLine("Enter First Name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayAccount()
        {
            Console.WriteLine("Account ID: " + AccountID + " | First Name: " + FirstName + " | Last Name: " + LastName + " | Balance: " + Balance);
        }
        
    }

    public class AccountCompare : IComparer<Account>
    {

        public enum sortBy
        {
            accountID,
            firstName,
            lastName,
            balance
        }

        //Sort two employee Ages  
        public sortBy compareByFields = sortBy.accountID;
        public int Compare(Account x, Account y)
        {
            switch (compareByFields)
            {
                case sortBy.accountID:
                    return x.GetAccountID().CompareTo(y.GetAccountID());
                case sortBy.firstName:
                    return x.GetFirstName().CompareTo(y.GetFirstName());
                case sortBy.lastName:
                    return x.GetLastName().CompareTo(y.GetLastName());
                case sortBy.balance:
                    return x.GetBalance().CompareTo(y.GetBalance());
                default: break;

            }
            return x.GetAccountID().CompareTo(y.GetAccountID());
        }
        /*int IComparer<Account>.Compare(Account? x, Account? y)
        {
            throw new NotImplementedException();
        }*/

    }
    public class AccountList 
    {
        public static List<Account> accountList = new List<Account>();
        public void addAccount()
        {
            Account a = new Account();
            a.FillInfor();
            accountList.Add(a);
        }
        public void DisplayList()
        {
            foreach (Account a in accountList)
            {
                a.DisplayAccount();
            }
        }
        public void NewAccount()
        {
            int n;
            Console.WriteLine("Amount Of Account: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                addAccount();
                n--;
            }
        }
        
        public void SaveFile()
        {
            Console.WriteLine("Input File Name to Save: ");
            string fileName = Console.ReadLine();

            try
            {
                FileStream output = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Account a in accountList)
                {
                    writer.WriteLine("{0}, {1}, {2}, {3}", a.AccountID, a.FirstName, a.LastName, a.Balance);
                }
                writer.Close();
                output.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFile()
        {
            Console.WriteLine("Input File Name to Load: ");
            string fileName = Console.ReadLine();
            accountList.Clear();
            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(',');

                    Account acc = new Account(list[0], list[1], list[2], double.Parse(list[3]));
                    accountList.Add(acc);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void RemoveAccount()
        {
            Console.WriteLine("Input ID Account You Want Remove ");
            string idRemove = Console.ReadLine();
            /*string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());
            accountList.Remove(new Account(idRemove, firstName, lastName, balance));*/
            /*var item = accountList.Single(x => x.AccountID == idRemove);*/
            var index = accountList.FindIndex(i => i.AccountID == idRemove);
            if (index >= 0)
            {   // ensure item found
                accountList.RemoveAt(index);
            }
        }
        public List<Account> GetListAccount()
        {
            List<Account> propertyList = new List<Account>();
            if (accountList != null)
            {
                foreach (var prop in accountList)
                {
                    propertyList.Add(prop);
                }
            }
            return propertyList;
        }
        internal void Sort(AccountCompare compare)
        {
            throw new NotImplementedException();
        }
    }
    

}