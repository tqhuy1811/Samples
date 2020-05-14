﻿namespace MockDelegates
{
    public class SimpleDelegateCalculator
    {
        Add _add;

        public SimpleDelegateCalculator(Add add)
        {
            _add = add;
        }

        public int Add(int a, int b)
        {
            return _add(a, b);
        }
    }
}
