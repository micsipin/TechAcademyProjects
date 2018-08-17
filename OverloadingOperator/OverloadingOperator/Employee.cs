﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingOperator
{
    class Employee : Person, IQuittable
    {
        public static int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine($"Name: [{FirstName} {LastName}]\r\nID: [{ID}]");
            Console.WriteLine($"Name: [{FirstName} {LastName}]\r\nID: [{ID}]");
        }

 
        public static bool operator==(Employee emp, Employee emp2)
        {
            return ID.Equals(ID);
        }
        public static bool operator !=(Employee emp, Employee emp2)
        {
            return Convert.ToBoolean(Employee.ID != E.ID);
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        public void Quit()
        {
            Console.WriteLine("Quit");
            Console.ReadLine();
        }
    }
}