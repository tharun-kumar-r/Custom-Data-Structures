using ConsoleApp1;

class Program
{
     public static void Main(String[] Aregs)
    {
       
        CustomQueue employeeQueue = new CustomQueue(3);

        Employee emp1 = new Employee("Tharun", "Male", "7483440063");
        Employee emp2 = new Employee("Madhu", "Male", "9123456789");
        Employee emp3 = new Employee("Rahul", "Male", "9988776655");
        Employee emp4 = new Employee("Kumar", "Male", "9988776655");

        employeeQueue.Enqueue(emp1);
        employeeQueue.Enqueue(emp2);
        employeeQueue.Enqueue(emp3);

        Console.WriteLine("Peek: -------- " + employeeQueue.Peek().Name);

        Console.WriteLine("Dequeuing employees from the queue:");
        while (!employeeQueue.IsEmpty())
        {
            Console.WriteLine("Peek: -------- " + employeeQueue.Peek().Name);
            employeeQueue.Dequeue();

            

        }

        
       
       

        CustomStack cstack = new CustomStack(3);
        try
        {
        
            cstack.Push(emp1);
            cstack.Push(emp2);
            cstack.Push(emp3);
            cstack.Push(emp4);
            Console.WriteLine("Peek: -------- " + cstack.Peek().Name);
            cstack.Push(emp1);
            Console.WriteLine("Poped : -----------" + cstack.Pop().Name);
            Console.WriteLine("Peek: ----------- " + cstack.Peek().Name);
        }
        catch (Exception e)
        { }

      


    }
}