using System;

namespace Module_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer wr = new Writer();
            ((IWriter)wr).Write();
            IWriter wr2 = new Writer();
            wr2.Write();
            Console.ReadKey();
        }
    }

    public interface IWriter
    {
        void Write()
        {
            Console.WriteLine("IWRITER");
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
