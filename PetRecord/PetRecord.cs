﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRecord
{
    class PetRecord
    {
        private string _name;
        private int _age;
        private double _weight;

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int Age
        {
            get { return this._age; }
            set
            {
                if(value >= 0)
                {
                    this._age = value;
                }
                else
                {
                    this._age = 0;
                }
            }
        }

        public double Weight
        {
            get { return this._weight; }
            set
            {
                if(value >= 0)
                {
                    this._weight = 0;
                }
                else
                {
                    this._weight = 0;
                }
            }
        }


        public PetRecord(String name, int age, double weight)
        {
            this.set(name, age, weight);
        }

        public void set(String name, int age, double weight)
        {
            this._name = name;
            if ((age < 0) || (weight < 0))
            {
                Console.WriteLine("Negative age or weight");
                Environment.Exit(0);
            }
            else
            {
                this._age = age;
                this._weight = weight;
            }
        }

        public PetRecord(string name)
        {
            this.set(name, 0, 0);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Weight: {2}",
                this._name, this._age, this._weight);
        }

        
    }
}
