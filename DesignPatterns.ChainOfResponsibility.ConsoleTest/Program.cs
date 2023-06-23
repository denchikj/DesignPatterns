using DesignPatterns.ChainOfResponsibility.Handlers;
using DesignPatterns.ChainOfResponsibility.Interfaces;
using DesignPatterns.ChainOfResponsibility.Requests;

namespace DesignPatterns.ChainOfResponsibility.ConsoleTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            IChain chain = new Chain.Chain();
            chain.AddNext(new PutHandler());
            chain.AddNext(new PostHandler());
            chain.AddNext(new GetHandler());
            chain.Handle(new PutRequest(3));
        }
    }
}