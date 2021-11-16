using System;
using System.ComponentModel.DataAnnotations;

namespace Module_10
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    public class ElectronicBook : IBook,IDevice
    {
        void IBook.Read()
        {
            throw new NotImplementedException();
        }

        void IDevice.TurnOn()
        {
            throw new NotImplementedException();
        }

        void IDevice.TurnOff()
        {
            throw new NotImplementedException();
        }
    }



    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update()
        {
            Console.WriteLine("Обновление сущности через интерфейс IUpdatable");
        }
    }

    public class Entity: ICreatable,IDeletable,IUpdatable
    {
        public void Create()
        {
            Console.WriteLine("Создали сущность");
        }

        public void Delete()
        {
            Console.WriteLine("Удалили сущность");
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
