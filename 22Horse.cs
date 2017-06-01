# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceReference
{
    class Horse : IAnimals,IHerbivorous
    {
        private string animalName;
        private string animalSpecies;
        public string AnimalName
        {
            get
            {
                return animalName;
            }
            set
            {
                animalName = value;
            }
        }
        public string AnimalSpecies
        {
            get
            {
                return animalSpecies;
            }
            set
            {
                animalSpecies = value;
            }
        }
        public void WhatMyNutritionType()
        {
            Console.WriteLine("I am herbivorous");
        }
    }
}
