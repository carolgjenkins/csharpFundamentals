using System;

namespace GradeBook
{
    public class Statistics
    {
        //field that holds the Average value
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        //field that holds the High value
        public double High;
        //field that holds the Low value
        public double Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    //var d contains the average grade result.Average
                    case var d when d >= 90.0:
                        return 'A';
                        
                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60.0:
                        return 'D';

                    default:
                        return 'F';
                }

            }
        }
        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}