using System;

namespace SingletonExercise
{
    public class Program
    {
        // Since implementing a singleton is easy, you have a different challenge: write a method called IsSingleton(). This method takes a factory 
        // method that returns an object and it's up to you to determine whether or not that object is a singleton instance. 

        public class SingletonTester
        {
            public static bool IsSingleton(Func<object> func)
            {
                var obj1 = func();
                var obj2 = func();
                return (obj1 == obj2);
            }
        }

        public class Person 
        {
            public string Name { get; set; }
        }

        public static Person CreateNonSingletonPerson()
        {
            return new Person();
        }


        private static Person SingletonPerson;
        public static Person CreateSingletonPerson()
        {
            if (SingletonPerson == null)
                SingletonPerson = new Person { Name = "Will" };

            return SingletonPerson;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SingletonTester.IsSingleton(CreateNonSingletonPerson));
            Console.WriteLine(SingletonTester.IsSingleton(CreateSingletonPerson));
        }


    }
}
