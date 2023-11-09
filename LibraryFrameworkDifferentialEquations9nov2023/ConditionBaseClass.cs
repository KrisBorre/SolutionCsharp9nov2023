﻿namespace LibraryFrameworkDifferentialEquations9nov2023
{
    public abstract class ConditionBaseClass
    {
        private double x = 0;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public ConditionBaseClass(double x)
        {
            this.x = x;
        }
    }
}
