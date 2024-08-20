using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CustomStack
    {
        private Employee[] _stack;
        private int _top;

        public  CustomStack(int size)
        {
            _stack = new Employee[size];
            _top = -1;
        }

        public void Push(Employee item)
        {
            if (_top == _stack.Length - 1)
            {
                Console.WriteLine("Stack overflow!");
                return;
            }
            _stack[++_top] = item;
            Console.WriteLine("Pushed " + item.Name);
        }

        public Employee Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow!");
                return null;
            }
            Employee emp = _stack[_top--];  
            emp.DisplayInfo();             
            return emp;

        }


        public Employee Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return null;
            }
            Employee emp = _stack[_top]; 
            emp.DisplayInfo();            
            return emp;
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }
    }
}
