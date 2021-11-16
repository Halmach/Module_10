﻿using System;

namespace Module_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker wr = new Worker();
            wr.Build();
            IWorker wr2 = new Worker();
            wr2.Build();
            
        }
    }

    public interface IWorker
    {
        public void Build();
    }

    public class Worker : IWorker
    {
        public void Build()
        {
            Console.WriteLine("Build project");
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
