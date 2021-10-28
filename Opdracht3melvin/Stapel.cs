using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht3melvin
{
    internal class Stapel<T>
    {
        private List<T> StapelLijst = new();
        private List<T> StapelLijstCopy = new();

        public void Toevoegen(T ToeTeVoegen)
        {
            StapelLijst.Add(ToeTeVoegen);
        }

        public T Verwijderen()
        {
            if (StapelLijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            T stapel = StapelLijst[StapelLijst.Count - 1];
            StapelLijst.RemoveAt(StapelLijst.Count - 1);

            return stapel;
        }

        public void Leegmaken()
        {
            StapelLijst.Clear();
        }

        public bool IsAanwezig(T TeZoeken)
        {
            for (int i = 0; i < StapelLijst.Count; i++)
            {
                if (StapelLijst[i].ToString() == TeZoeken.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string List = "";
            foreach (T t in StapelLijst)
            {
                List += t.ToString() + "; ";
            }

            return List;
        }

        public List<T> StapelCopy()
        {
            StapelLijstCopy = StapelLijst.GetRange(0, StapelLijst.Count); ;
            return StapelLijstCopy;
        }
    }

    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return "Naam: " + Name + " leeftijd: " + Age;
        }

        //public override StapelCopy()
        //{

        //}
    }

}
