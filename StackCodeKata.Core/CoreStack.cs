namespace StackCodeKata.Core
{
    public class CoreStack
    {
        public Object[] Stack { get; set; }
        public int Top { get; set; }

        public CoreStack(int size)
        {
            Stack = new Object[size];
            Top = -1;
        }

        public void Push(Object value)
        {
            if (Top == Stack.Length - 1)
            {
                throw new Exception("Stack is full");
            }
            Top++;
            Stack[Top] = value;
        }

        public Object Pop()
        {
            if (Top == -1)
            {
                throw new Exception("Stack is empty");
            }
            Object value = Stack[Top];
            Top--;
            return value;
        }

        public Object Peek()
        {
            if (Top == -1)
            {
                throw new Exception("Stack is empty");
            }
            return Stack[Top];
        }

        public bool IsEmpty()
        {
            return Top == -1;
        }

        public bool IsFull()
        {
            return Top == Stack.Length - 1;
        }
    }
}