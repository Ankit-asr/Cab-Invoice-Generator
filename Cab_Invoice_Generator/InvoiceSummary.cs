﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Generator
{
    public class InvoiceSummary
    {
        public int numOfRides;
        public double totalFare;
        public double averageFare;
        public InvoiceSummary(int numOfRides, double totalFare)
        {
            this.numOfRides = numOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare / numOfRides;
        }
    }
}