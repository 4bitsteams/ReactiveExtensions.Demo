using System;
using System.Reactive.Linq;

namespace ReactiveExtensions.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable.Range(1, 100).Where(x => x % 2 == 0)
               .Merge(Observable.Range(1, 100).Where(x => x % 2 == 0))
               .Subscribe(Console.WriteLine);

            //var evenNumber = new EvenNumberObservable();
            //var consoleLogObservable = new ConsoleLogObservable();
            //evenNumber.Subscribe(consoleLogObservable);
            Console.WriteLine("Completed!");
            Console.ReadLine();
        }
    }
}
