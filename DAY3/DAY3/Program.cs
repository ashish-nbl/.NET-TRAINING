//class AsyncPractice
//{
//    //public static  async void Example()  //not allowed to wait for void 
//    public static async Task<int> Example()

//    {
//        Console.WriteLine("Before");

//        await Task.Delay(2000); // non-blocking wait

//        Console.WriteLine("After");

//        return 90;
//    }
//    public static async Task Main()
//    {
//         int result=await Example();
//        Console.WriteLine(result);
//        Console.WriteLine("Hello");
//    }
//}


//class AsyncEx
//{
//    public static void SyncDemo()
//    {
//        Console.WriteLine("sync method start ...");
//        Thread.Sleep(3000); //bocks the main thread
//        Console.WriteLine("after 3 sec sync method frees the main thread");
//    }

//    public static async Task AsyncDemo()
//    {

//        Console.WriteLine("Async method start ...");
//        await Task.Delay(3000); // I/O bound operations like api call ..
//        Console.WriteLine("Async finish");
//    }

//    public static async Task Main()
//    {
//        SyncDemo();
//        await AsyncDemo();
//    }

//}



//class AsyncEx
//{
//    public static async Task Main()
//    {
//        Console.WriteLine("Starting ...");
//        var t = Task.Run(() =>
//        {
//            Console.WriteLine("Hello Ashish");
//            return 10;
//        });

//        await Task.Run(() => Console.WriteLine("Task"));
//        Console.WriteLine(t.Status);
//        Console.WriteLine(t.Result);
//        Console.WriteLine(t.Status);

//        Console.WriteLine(t);

//        Console.WriteLine("End");

//        await t;
//        Console.WriteLine(t.Result);
//        Console.WriteLine(t.Status);
//        Console.WriteLine(t.Result);



//    }
//}


//class AsyncExceptionHandling
//{
//    public static async Task AsyncTest()
//    {
//        await Task.Delay(1000);
//        throw new Exception("Exception is occurs");
//    }

//    public static async Task Main()
//    {
//        try
//        {
//            await AsyncTest();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}


//sync vs async vs multithreading


//using System;
//using System.Diagnostics;
//using System.Threading;
//using System.Threading.Tasks;

//namespace AsyncTest
//{
//    class Program
//    {
//        static void RunSeconds(double seconds)
//        {
//            int ms = (int)(seconds * 1000);

//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();
//            Console.WriteLine($"Thread started to run for {seconds} seconds");
//            Thread.Sleep(ms);
//            stopwatch.Stop();

//            Console.WriteLine($"Stopwatch passed {stopwatch.ElapsedMilliseconds} ms.");
//        }

//        static async Task RunSecondsAsync(double seconds)
//        {
//            int ms = (int)(seconds * 1000);

//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();
//            Console.WriteLine($"Thread started to run for {seconds} seconds");
//            await Task.Run(() => Thread.Sleep(ms));
//            //await Task.Delay(ms);
//            stopwatch.Stop();

//            Console.WriteLine($"Stopwatch passed {stopwatch.ElapsedMilliseconds} ms.");
//        }

//        static void RunSecondsThreaded(double seconds)
//        {
//            Thread th = new Thread(() => RunSeconds(seconds));
//            th.Start();
//        }

//        static async Task Main()
//        {
//            Console.WriteLine("Synchronous:");
//            RunSeconds(2.5); RunSeconds(2);

//            Console.WriteLine("\nAsynchronous:");
//            Task t1 = RunSecondsAsync(2.5); Task t2 = RunSecondsAsync(2);
//            await t1; await t2;

//            Console.WriteLine("\nMultithreading:");
//            RunSecondsThreaded(2.5); RunSecondsThreaded(2);
//        }
//    }
//}


using System.Diagnostics;

public class WhenAllDemo
{
    public static async Task WhenAllDemoMethod()
    {
        await Task.Delay(2000);
    } 
    public static async Task Main()
    {
        Stopwatch sw=new Stopwatch();
        sw.Start();


        Task t1=WhenAllDemoMethod();
        Task t2=WhenAllDemoMethod();
        Task t3=WhenAllDemoMethod();

        await Task.WhenAll(t1,t2,t3);

        sw.Stop();

        Console.WriteLine("Total Time in ms: "+sw.ElapsedMilliseconds);
    }
}