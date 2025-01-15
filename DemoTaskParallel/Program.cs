namespace DemoTaskParallel
{
    internal class Program
    {
        public static void PrintNumnber(string message)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($" {message} : {i}");
                Thread.Sleep(1000);
            }
        }//end PrintNumber
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";
            //create a task by using a lambda expression
            Task task01 = new Task(() => PrintNumnber("Task 01"));
            task01.Start();
            //Create a task by using delegate and run the task 
            Task task02 = Task.Run(delegate { PrintNumnber("Task 02"); });
            //create a task by using a Action delegate
            Task task03 = new Task(new Action(() => { PrintNumnber("Task 03"); }));
            task03.Start();
            Console.WriteLine($"Thread '{Thread.CurrentThread.Name}'");
            Console.ReadKey();
        }//end Main
    }//end Program
}
