using System;
using System.Collections.Generic;

namespace Class_Udvoitel
{
    class Udvoitel
    {
        public int Current { get; private set; }
        public int Count { get; private set; } = 0;
        public int Finish { get; private set; }
        Stack<int> history = new Stack<int>();

        public int Steps
        {
            get
            {
                int f = Finish;
                int i = 0;
                while (f != 1)
                {
                    f = f % 2 == 0 ? f / 2 : f - 1;
                    i++;
                }
                return i;
            }
        }

        public Udvoitel(int min, int max)
        {
            Finish = new Random().Next(min, max+1);
        }

        public Udvoitel()
        {
            Finish = new Random().Next(10, 101);
        }

        public Udvoitel(int finish)
        {
            Finish = finish;
        }

        public int Plus()
        {
            history.Push(Current);
            Current++;
            Count = history.Count;
            return Current;
        }

        public int Multi()
        {
            history.Push(Current);
            Current *= 2;
            Count = history.Count;
            return Current;
        }

        public void Reset()
        {
            Current = 0;
            history.Clear();
            Count = 0;
        }

        public void Back()
        {
            if (history.Count != 0)
            {
                Current = history.Pop();
                Count = history.Count;
            }
            else
                Current = 0;
        }

        public override string ToString()
        {
            return Current.ToString();
        }

        public bool CheckResult()
        {
            return Current == Finish;
        }

        public bool CheckSteps()
        {
            return Steps == Count;
        }
    }
}
