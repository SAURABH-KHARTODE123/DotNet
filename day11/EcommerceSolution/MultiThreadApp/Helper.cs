using System;
namespace Utility;
using System.Threading;

public static class Helper
{
    public static async Task StoreData()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Current thread Id " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("storing data");
        });
    }

    public static async Task PrintingData()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Current thread Id " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Printing data");
        });
    }

    public static async Task GetData()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Current thread Id: " + Thread.CurrentThread.ManagedThreadId);
        });
    }


}