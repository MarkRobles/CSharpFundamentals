using System;
using System.Collections.Generic;

public class Statistics
{
    public Statistics()
    {
        Count = 0;
        Sum = 0;

        High = double.MinValue;
        Low = double.MaxValue;
    }

    public void Add(double number)
    {
        Sum += number;
        Count += 1;
        Low = Math.Min(number, Low);
        High = Math.Max(number, High);
    }

    //It is not neceessary that classes outside this, calcualte and set the average, so we just make it readable
    public double Average
    {
        get
        { return Sum / Count; }
    }
    public double Low { get; set; }
    public double High { get; set; }
    public char Letter
    {
        get
        {

            switch (Average)
            {
                case var d when d >= 90.0:
                    return 'A';

                case var d when d >= 80.0:
                    return 'B';

                case var d when d >= 70.0:
                    return 'C';
                    
                case var d when d >= 600.0:
                    return 'D';

                default: return 'F';
            }
        }
    }
    public double Sum;
    public int Count;



}