

/// C# - Multithreading
/// 

/// Thread Life Cycle
/// 

/// The Main Thread
/// 

//using System;
//using System.Threading;

//namespace MultithreadingApplication
//{
//    class MainThreadProgram
//    {
//        static void Main(string[] args)
//        {
//            Thread th = Thread.CurrentThread;
//            th.Name = "MainThread";

//            Console.WriteLine("This is {0}", th.Name);
//            Console.ReadKey();
//        }
//    }
//}

/// Creating Threads
/// 

//using System;
//using System.Threading;

//namespace MultithreadingApplication
//{
//    class ThreadCreationProgram
//    {
//        public static void CallToChildThread()
//        {
//            Console.WriteLine("Child thread starts");
//        }
//        static void Main(string[] args)
//        {
//            ThreadStart childref = new ThreadStart(CallToChildThread);
//            Console.WriteLine("In Main: Creating the Child thread");
//            Thread childThread = new Thread(childref);
//            childThread.Start();
//            Console.ReadKey();
//        }
//    }
//}

/// Managing Threads
/// 

//using System;
//using System.Threading;

//namespace MultithreadingApplication
//{
//    class ThreadCreationProgram
//    {
//        public static void CallToChildThread()
//        {
//            Console.WriteLine("Child thread starts");

//            // the thread is paused for 5000 milliseconds
//            int sleepfor = 5000;

//            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
//            Thread.Sleep(sleepfor);
//            Console.WriteLine("Child thread resumes");
//        }

//        static void Main(string[] args)
//        {
//            ThreadStart childref = new ThreadStart(CallToChildThread);
//            Console.WriteLine("In Main: Creating the Child thread");

//            Thread childThread = new Thread(childref);
//            childThread.Start();
//            Console.ReadKey();
//        }
//    }
//}

/// Destroying Threads
/// 

//using System;
//using System.Threading;

//namespace MultithreadingApplication
//{
//    class ThreadCreationProgram
//    {
//        public static void CallToChildThread()
//        {
//            try
//            {
//                Console.WriteLine("Child thread starts");

//                // do some work, like counting to 10
//                for (int counter = 0; counter <= 10; counter++)
//                {
//                    Thread.Sleep(500);
//                    Console.WriteLine(counter);
//                }

//                Console.WriteLine("Child Thread Completed");
//            }
//            catch (ThreadAbortException e)
//            {
//                Console.WriteLine("Thread Abort Exception");
//            }
//            finally
//            {
//                Console.WriteLine("Couldn't catch the Thread Exception");
//            }
//        }
//        static void Main(string[] args)
//        {
//            ThreadStart childref = new ThreadStart(CallToChildThread);
//            Console.WriteLine("In Main: Creating the Child thread");

//            Thread childThread = new Thread(childref);
//            childThread.Start();

//            //stop the main thread for some time
//            Thread.Sleep(2000);

//            //now abort the child
//            Console.WriteLine("In Main: Aborting the Child thread");

//            childThread.Abort();
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Threading;

//namespace MultithreadingApplication
//{
//    class ThreadCreationProgram
//    {
//        static void CallToChildThread(CancellationToken token)
//        {
//            try
//            {
//                Console.WriteLine("Child thread starts");

//                // Do some work, like counting to 10
//                for (int counter = 0; counter <= 10; counter++)
//                {
//                    if (token.IsCancellationRequested)
//                    {
//                        Console.WriteLine("Child thread cancellation requested");
//                        break;
//                    }

//                    Thread.Sleep(500);
//                    Console.WriteLine(counter);
//                }

//                Console.WriteLine("Child Thread Completed");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine($"Exception in child thread: {e.Message}");
//            }
//        }

//        static void Main(string[] args)
//        {
//            CancellationTokenSource cts = new CancellationTokenSource();
//            CancellationToken token = cts.Token;

//            Console.WriteLine("In Main: Creating the Child thread");

//            Thread childThread = new Thread(() => CallToChildThread(token));
//            childThread.Start();

//            // Stop the main thread for some time
//            Thread.Sleep(2000);

//            // Now request cancellation for the child thread
//            Console.WriteLine("In Main: Requesting cancellation for the Child thread");
//            cts.Cancel();

//            // Wait for the child thread to complete
//            childThread.Join();

//            Console.WriteLine("In Main: Child thread has been stopped");
//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Threading;

namespace MultithreadingApplication
{
    class ThreadCreationProgram
    {
        public static void CallToChildThread(CancellationToken token)
        {
            try
            {
                Console.WriteLine("Child thread starts");

                for (int counter = 0; counter <= 10; counter++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Child thread received cancellation request");
                        throw new OperationCanceledException();
                    }

                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(() => CallToChildThread(token));
            childThread.Start();

            // Stop the main thread for some time
            Thread.Sleep(2000);

            // Now cancel the child thread
            Console.WriteLine("In Main: Aborting the Child thread");
            cts.Cancel();

            childThread.Join(); // Wait for the child thread to finish
            Console.ReadKey();
        }
    }
}
