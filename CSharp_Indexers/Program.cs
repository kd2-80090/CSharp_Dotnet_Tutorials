

/// C# - Indexers
/// 

//using System;

//namespace IndexerApplication
//{

//    class IndexedNames
//    {
//        private string[] namelist = new string[size];
//        static public int size = 10;

//        public IndexedNames()
//        {
//            for (int i = 0; i < size; i++)
//                namelist[i] = "N. A.";
//        }
//        public string this[int index]
//        {
//            get
//            {
//                string tmp;

//                if (index >= 0 && index <= size - 1)
//                {
//                    tmp = namelist[index];
//                }
//                else
//                {
//                    tmp = "";
//                }

//                return (tmp);
//            }
//            set
//            {
//                if (index >= 0 && index <= size - 1)
//                {
//                    namelist[index] = value;
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            IndexedNames names = new IndexedNames();
//            names[0] = "Vaibhav";
//            names[1] = "Hrishikesh";
//            names[2] = "Neha";
//            names[3] = "Bharati";
//            names[4] = "Shivam";
//            names[5] = "Sunil";
//            names[6] = "Rupesh";

//            for (int i = 0; i < IndexedNames.size; i++)
//            {
//                Console.WriteLine(names[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}

/// Overloaded Indexers
/// 

using System;

namespace IndexerApplication
{
    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A.";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Nilesh";
            names[1] = "Hruta";
            names[2] = "Neha";
            names[3] = "Amar";
            names[4] = "Dravid";
            names[5] = "Sunil";
            names[6] = "Rudra";

            //using the first indexer with int parameter
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            //using the second indexer with the string parameter
            Console.WriteLine(names["Neha"]);
            Console.ReadKey();
        }
    }
}