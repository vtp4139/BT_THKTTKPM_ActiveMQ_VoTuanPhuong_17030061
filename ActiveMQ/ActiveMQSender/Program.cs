using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;

namespace ActiveMQSender
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo connection factory
            IConnectionFactory factory = new NMSConnectionFactory("tcp://localhost:61616");
            //tạo connection
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();//nối tới MOM
            //tạo session
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            //tạo producer
            ActiveMQQueue destination = new ActiveMQQueue("Võ Tuấn Phương");
            IMessageProducer producer = session.CreateProducer(destination);
            //send messageHướng 

             //biến đối tượng thành XML document String
            Person p = new Person(17030061, "votuanphuong", new DateTime(1999,11,01));

            //string xml = genXML(p).ToLower();
            string xml = new XMLObjectConverter<Person>().object2XML(p);
            Console.WriteLine(xml.ToLower());

            //Tạo message và gửi đi
            Console.WriteLine("Nhap message: ");
            String m = Console.ReadLine();

            IMessage msg = new ActiveMQTextMessage(m);
            producer.Send(msg);

            Console.WriteLine("Sending message. Enter to exit !");
            //shutdown
            session.Close();
            con.Close();
            Console.ReadKey();
        }
    }    
}
