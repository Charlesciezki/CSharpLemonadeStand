﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Customer
    {
        public Random random = new Random();
        public List<AngryCustomer> AngryCustomerList = new List<AngryCustomer>();
        public List<NormalCustomer> NormalCustomerList = new List<NormalCustomer>();
        public List<ThirstyCustomer> ThirstyCustomerList = new List<ThirstyCustomer>();
        public double theModifier;

        public void customers(double modifier) //TAKE IN THE TOTAL MODIFIER FROM DAY CLASS AND PUT IT AS AN + TO BASECHANCE!!!!!!!!!!!
        {
            theModifier = modifier;
            for (int customer = 0; customer < random.Next(33, 56); customer++)
            {
                AngryCustomer angryCustomer = new AngryCustomer(random.Next(5, 11) + theModifier, random.Next(0, 5));
                AngryCustomerList.Add(angryCustomer);

                NormalCustomer normalCustomer = new NormalCustomer(random.Next(10, 21) + theModifier, random.Next(0, 5));
                NormalCustomerList.Add(normalCustomer);

                ThirstyCustomer thirstyCustomer = new ThirstyCustomer(random.Next(20, 26) + theModifier, random.Next(0, 5));
                ThirstyCustomerList.Add(thirstyCustomer);
            }
            foreach (AngryCustomer customer in AngryCustomerList)
            {
                Console.WriteLine(customer.AngryCustomerBaseChance + " " + customer.AngryCustomerName);
            }
            Console.WriteLine("----------------------------------------------");

            foreach (NormalCustomer customer in NormalCustomerList)
            {
                Console.WriteLine(customer.NormalCustomerBaseChance + " " + customer.NormalCustomerName);
            }

            Console.WriteLine("----------------------------------------------");

            foreach (ThirstyCustomer customer in ThirstyCustomerList)
            {
                Console.WriteLine(customer.ThirstyCustomerBaseChance + " " + customer.ThirstyCustomerName);
            }
        }

    }
}
