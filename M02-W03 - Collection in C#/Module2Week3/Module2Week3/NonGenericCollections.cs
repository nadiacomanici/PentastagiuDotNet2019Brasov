using System.Collections;

namespace Module2Week3
{
    class NonGenericCollections
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

        /*static*/ void Main()
        {
            // *** Array List ***
            // ArrayList can contain multiple null and duplicate values.
            // can contain elements of any data types 

            ArrayList al = new ArrayList();
            al.Add("some text");
            al.Add(new Element("an object", 2));

            al.AddRange(new ArrayList { 22, true, "other" });

            int index = al.IndexOf("some text");

            al.Reverse();

            al.RemoveAt(index);

            IList al2 = new ArrayList(5);
            al2.Add(22);
            al2.Add("22");

            // *** Stack ***
            // allows null value and also duplicate values
            Stack stack = new Stack();

            stack.Push("first element");
            stack.Push(2);
            stack.Push(null);
            stack.Push("another");
            stack.Push(2);

            var removedItem = stack.Pop();
            var topItem = stack.Peek();

            var containsNull = stack.Contains(null);
            var containsThe = stack.Contains("the");
            //stack.Clear();

            var doi = stack.Clone();

            // *** Queue ***
            // opposite of the Stack
            // allows multiple null and duplicate values

            Queue q = new Queue();

            q.Enqueue("something");
            q.Enqueue(null);
            q.Enqueue("something");
            q.Enqueue(2222);
            q.Enqueue(2222);

            var removed = q.Dequeue();
            var top = q.Peek();

            var containSomething = q.Contains("something");
            q.Clear();

            // *** HashTable ***
            // stores key-value pairs
            // Key and value can be of any data type
            // Key cannot be null whereas value can be nul
            // unique keys

            Hashtable ht = new Hashtable();
            ht.Add("key1", new Element("el", 111));
            ht.Add(1, "something");
            ht.Add(true, null);
            ht.Add("3", true);
            //ht.Add("3", "other"); // exception: key already added

            ht.Remove("key1");
            var containsKey = ht.ContainsKey("3"); // same as ".Contains
            var containsValue = ht.ContainsValue("something");

            // *** SortedList ***
            // stores key-value pairs in the ascending order of key by default
            // elements can be accessed both by key and index
            // Key cannot be null but value can be null
            // datatype of all keys must be same, so that it can compare otherwise it will throw runtime exception

            SortedList sl = new SortedList();
            sl.Add(1, "something");
            sl.Add(5, "s2");
            sl.Add(2, "s3");
            sl.Add(44, "s4");
            //sl.Add("key1", "s5"); // Exception: failure to compare

            sl.RemoveAt(1);
            var keyForIndex2 = sl.GetKey(2);
            var indexOfKey = sl.IndexOfKey(5);
            var indexOfValue = sl.IndexOfValue("s2");
            var containByKey = sl.Contains(44);

            sl.Remove(44); //by key
            var containByKey2 = sl.Contains(44);


        }
    }
}
