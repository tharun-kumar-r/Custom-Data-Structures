using ConsoleApp1;

public class CustomQueue
{
    private Employee[] _queue;
    private int _front;
    private int _rear;
    private int _count;

    public CustomQueue(int size)
    {
        _queue = new Employee[size];
        _front = 0;
        _rear = -1;
        _count = 0;
    }


    public void Enqueue(Employee employee)
    {
        if (_count == _queue.Length)
        {
            Console.WriteLine("Queue overflow!");
            return;
        }

        _rear = (_rear + 1) % _queue.Length;
        _queue[_rear] = employee;
        _count++;
        Console.WriteLine($"Enqueued: {employee.Name}");
    }

 
    public Employee Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue underflow!");
            return null;
        }

        Employee emp = _queue[_front];
        _front = (_front + 1) % _queue.Length;
        _count--;
        Console.WriteLine($"Dequeued: {emp.Name}");
        emp.DisplayInfo();
        return emp;
    }


    public Employee Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return null;
        }
      
        Employee emp = _queue[_front];
  
        return emp;
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }
}