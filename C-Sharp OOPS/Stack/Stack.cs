using System;
using System.Collections.Generic;

namespace C_Sharp_OOPS
{
    public class Stack
    {
        private readonly List<object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null object is not allowed.");
            
            _stack.Add(obj);

        }


        public object Pop()
        {
            if(_stack.Count == 0)
                throw new InvalidOperationException("An empty stack can not pop element.");

            var index = _stack.Count - 1;
            var object1 = _stack[index];
            _stack.RemoveAt(index);
            return object1;

        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}