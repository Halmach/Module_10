using System;

namespace Module_10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter wr = new FileManager();
            IReader rd = new FileManager();
            IMailer mailer = new FileManager();
            wr.Write();
            rd.Read();
            mailer.SendEmail();

        }
    }

    public class FileManager:IWriter,IReader,IMailer
    {
        public void Read()
        {
            Console.WriteLine("Чтение из файла");
        }

        public void SendEmail()
        {
            Console.WriteLine("Отправка сообщения");
        }
    }


    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public interface IWorker
    {
         void Build();
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Build project");
        }
    }

    public interface IWriter
    {
        void Write()
        {
            Console.WriteLine("Реализация интерфейса IWriter");
        }
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Writer");
        }
    }

    public class Manager : IManager
    {
        public void Create()
        { 

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }

    public interface IManager
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
