public class Program
{
    static void Main(string[] args)
    {
        Publisher p = new Publisher();
        Hue hue = new Hue();
        DaNang dn = new DaNang();

        hue.Sub(p);
        dn.Sub(p);

        p.Send();

    }
    public class Publisher
    {
        public delegate void NotifyNews(object data);

        public NotifyNews event_news;

        public void Send()
        {
            event_news?.Invoke("Co tin nhan moi");
        }
    }

    // SubscriberA lớp này đăng ký nhận sự kiện từ Publisher,
    // bằng phương thức Sub, khi sự kiện xảy ra nó sẽ gọi ReceiverFromPublisher
    public class Hue
    {
        public void Sub(Publisher p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("From Hue: " + data.ToString());
        }
    }

    // SubscriberA lớp này đăng ký nhận sự kiện từ Publisher,
    // bằng phương thức Sub - khi đăng ký nó hủy việc nhận sự kiện của các đối tượng khác,
    // khi sự kiện xảy ra nó sẽ gọi ReceiverFromPublisher
    public class DaNang
    {
        public void Sub(Publisher p)
        {
            p.event_news = null;  // Hủy các đối tượng khác nhận sự kiện
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("From DN: " + data.ToString());
        }
    }


}
