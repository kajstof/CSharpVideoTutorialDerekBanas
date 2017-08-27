using System.Collections;
using System.Collections.Generic;

namespace derek_csharp_14
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm()
        {
        }

        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count { get => animalList.Count; }

        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}
