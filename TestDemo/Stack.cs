namespace TestDemo;

/// <summary>
/// Last-In-First-Out container.
/// </summary>
public class Stack
{
    private class StackElement
    {
        private int value;

        public StackElement? Next { get; set; }

        public int Value
        {
            get
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    return 0;
                }
                return value;
            }

            set { this.value = value; }
        }

        public StackElement(int value, StackElement? next)
        {
            this.value = value;
            this.Next = next;
        }
    }

    private StackElement? head;

    public void Push(int value)
        => head = new StackElement(value, head);

    public int Pop()
    {
        int value = head == null ? 0 : head.Value;
        head = head?.Next;
        return value;
    }

    public bool IsEmpty => head == null;
}
