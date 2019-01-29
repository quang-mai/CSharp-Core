﻿using DueDateService.Calculator;
using System;

namespace DueDateService
{
    internal class CalculatorFactory
    {
        public ICalculator GetCalculator(string frequency)
        {
            var frequencyWithoutHyphen = frequency.Replace("-", string.Empty);

            if (string.Equals(frequencyWithoutHyphen, "monthly", StringComparison.OrdinalIgnoreCase))
            {
                return new MonthlyCalculator();
            }
            if (string.Equals(frequencyWithoutHyphen, "semimonthly", StringComparison.OrdinalIgnoreCase))
            {
                return new SemiMonthlyCalculator();
            }
            if (string.Equals(frequencyWithoutHyphen, "biweekly", StringComparison.OrdinalIgnoreCase))
            {
                return new BiWeeklyCalculator();
            }

            throw new Exception("Invalid frequency.");
        }
    }
}
