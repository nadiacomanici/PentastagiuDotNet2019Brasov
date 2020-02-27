
using System;
using System.Collections.Generic;

namespace Module2Week3
{
    class GenericCollections
    {
        public class Element
        {
            public Element(string l, int v)
            {
                this.Label = l;
                this.Value = v;
            }

            public string Label { get; set; }
            public int Value { get; set; }
        }

        static void Main()
        {
            // *** List<T> ***
            // equivalent of the ArrayList class
            // Methods such as Contains, IndexOf, LastIndexOf, and Remove use an equality comparer
            // Methods such as BinarySearch and Sort use an ordering comparer
            // https://docs.microsoft.com/en-us/dotnet/standard/collections/comparisons-and-sorts-within-collections

            List<Element> list1 = new List<Element>();

            var el1 = new Element("age", 75);
            var el2 = new Element("weight", 75);
            var el3 = new Element("height", 75);

            list1.Add(el1);
            list1.Add(el2);
            list1.Add(el3);
            int indexEl2 = list1.IndexOf(el2);
            bool ex1Exist = list1.Contains(el1);
            //list1.Remove(el2);
            //list1.RemoveAt(1);
            Element result = list1.Find(item => item.Value == 75);
            

            foreach(Element item in list1)
            {
                Console.WriteLine(string.Format("Label: {0},  Value: {1}", item.Label, item.Value));
            }

            IEnumerable<Element> list2 = new List<Element>(list1);
            list2.GetEnumerator(); // we have only methods from IEnumerable

            //we can use it only to read from it
            IReadOnlyList<Element> readOnlyList = new List<Element>(list1);
            foreach(Element item in readOnlyList)
            {
                Console.WriteLine(string.Format("Label: {0},  Value: {1}", item.Label, item.Value));
            }

            // *** Dictionary<TKey,TValue> ***
            Dictionary<int, Element> dict = new Dictionary<int, Element>();
            //SortedList<int, Element> sl3 = new SortedList<int, Element>();
            Element el = new Element("age", 20);
            dict.Add(1, el);
            dict.Add(6, el);
            dict.Add(4, new Element("height", 175));

            var keys = dict.Keys;
            var values = dict.Values;

            Element resultValue;
            bool value = dict.TryGetValue(12, out resultValue);

            bool added = dict.TryAdd(4, new Element("weight", 80));

            dict.Remove(6);

            bool keyExist = dict.ContainsKey(4);
            bool valueExist = dict.ContainsValue(el);

            foreach(KeyValuePair<int, Element> item in dict)
            {
                Console.WriteLine(string.Format("from dictionary: {0} -> {1}", item.Value.Label, item.Value.Value));
            }


            //Create test togheter with the students
            // *** SortedList<T> ***


            // *** Hashset<T> ***
            HashSet<Element> hs = new HashSet<Element>();

            hs.Add(el);
            hs.Add(el);


        }
    }
}
