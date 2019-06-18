using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P110_ConsoleDemo
{
    class Program
    {
        //public delegate bool IntChecker(int n);
        static void Main(string[] args)
        {
            #region Delegate
            //Sum(IsEven, 10, 12, 15, 24, 30);

            //Sum(IsDivisibleBy3, 20, 45, 65, 12, 20);

            //Sum(
            //   delegate (int c) 
            //   {
            //        return c > 18;
            //   },
            //   15, 20, 25, 56
            //);

            //Sum(n => n > 18, 20, 45, 65);

            //Düymə düymə = new Düymə() { Name = "Qirmizi duyme" };

            //düymə.Click += Click_Listener;
            //düymə.Click += (o, e) => Console.WriteLine("Cl9ick bas verdi");

            //düymə.TriggerClick();
            #endregion

            #region Thread
            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);

            //thread1.IsBackground = false;
            //thread2.IsBackground = true;

            //int workerThreads;
            //int activeThreads;

            //ThreadPool.GetAvailableThreads(out workerThreads, out activeThreads);

            //Console.WriteLine(workerThreads + " " + activeThreads);

            //thread1.Start();
            //thread2.Start();

            //Console.WriteLine("Main thread islerini bitirir.");
            #endregion

            #region Practice Action Delegate
            //1st way
            //Action<int> act = new Action<int>(A);
            //act(10);

            //2nd way
            //Action<int> act = A;
            //act(13);

            //Anonymous delegate
            //Action<string> act = delegate (string s)
            //{
            //    Console.WriteLine(s);
            //};
            //act("text");

            //Lambda expression
            //Action<string> act = s => Console.WriteLine(s);
            //act("text2");
            #endregion

            #region Practice Function Delegate
            //Func<int, int> func = new Func<int, int>(B);
            //Console.WriteLine(func(10));

            //Func<int, int> func = B;
            //Console.WriteLine(func(13));

            //Func<int, string> func = delegate (int n)
            //{
            //    return n + " text";
            //};
            //Console.WriteLine(func(10));

            //Func<int, string> func = n => n + " text2";
            //Console.WriteLine(func(13));
            #endregion

            #region Practice Thread and Task
            //Thread th = new Thread(A); //unstarted
            //th.Start(); //runnable
            //Console.WriteLine(th.ThreadState);
            //Console.WriteLine(th.Priority);
            //Console.WriteLine(th.IsAlive);
            //Console.WriteLine(th.IsBackground);
            //Console.WriteLine(th.Name = "ThreadBaba");

            //Thread th = new Thread(B);
            //Thread th2 = new Thread(C);
            //th2.Priority = ThreadPriority.Highest; //but it is not guarenteed because of being unpredictable
            //th.Start();
            //th2.Start();
            //th2.Abort(); //Dead


            //Console.WriteLine(D());
            E(); //???


            #endregion


        }

        #region Practice Thread and Task
        //static void A()
        //{
        //    Console.WriteLine("I am a thread in your CPU");
        //}

        //static void B()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine(i);
        //        //Thread.Sleep(500); //Snake???
        //    }
        //}

        //static void C()
        //{
        //    for (int i = 20; i >= 0; i--)
        //    {
        //        Console.WriteLine(i + "C");
        //    }
        //}

        static long D()
        {
            long sum = 0;
            for (long i = 1; i <= 2019201920; i++)
            {
                sum += i;
            }
            return sum;
        }

        async static void E()
        {
            long result1 = await AsyncD();
            long result2 = await AsyncD();

            Console.WriteLine(result1 + result2);
        }

        static Task<long> AsyncD()
        {
            Task<long> task = Task.Run(() =>
            {
                return D();
            });

            return task;
        }
        #endregion


        #region Practice Action & Function Delegate
        //static void A(int n)
        //{
        //    Console.WriteLine(n);
        //}
        //static int B(int n)
        //{
        //    return n;
        //}
        #endregion



        //static void Loop1()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine("M1: " + (i+1));
        //    }
        //}

        //static void Loop2()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine("M2: " + (i + 1));
        //    }
        //}

        //static void Click_Listener(object sender, DuymeEventArgs e)
        //{
        //    Console.WriteLine($"Duymede click bas verdi, qulaq as. Tarix: {e.Date}");
        //}

        //static int Sum(Func<int, bool> callBack, params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if(callBack(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //static bool IsEven(int n) => n % 2 == 0;

        //static bool IsDivisibleBy3(int n) => n % 3 == 0;
    }

    //class Düymə
    //{
    //    public string Name { get; set; }

    //    public event Action<object, DuymeEventArgs> Click;

    //    public void TriggerClick()
    //    {
    //        Console.WriteLine("Click etdiniz");

    //        Click?.Invoke(this, new DuymeEventArgs() {
    //            Date = DateTime.Now
    //        });
    //    }
    //}

    //public class DuymeEventArgs : EventArgs
    //{
    //    public DateTime Date { get; set; }
    //}

}

