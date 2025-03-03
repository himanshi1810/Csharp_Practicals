using System;

namespace Practical06
{
    // Define a delegate
    public delegate void ProcessCompletedEventHandler();

    // Class containing business logic
    public class ProcessBusinessLogic
    {
        // Declare the event using the delegate
        public event ProcessCompletedEventHandler? ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");

            // Simulating some process...
            System.Threading.Thread.Sleep(2000);

            // Raise the event
            OnProcessCompleted();
        }
        //Protected Virtual Method
        protected virtual void OnProcessCompleted()
        {
            // Invoke event if there are subscribers
            ProcessCompleted?.Invoke();
        }
    }

    class Program
    {
        static void Main()
        {
            // Instantiate the business logic class
            ProcessBusinessLogic process = new ProcessBusinessLogic();

            // Subscribe to the event
            process.ProcessCompleted += Bl_ProcessCompleted;

            // Start the process
            process.StartProcess();

            Console.ReadLine();
        }

        // Event handler method
        private static void Bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }
}
