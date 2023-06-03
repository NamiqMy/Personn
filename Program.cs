namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Namiq", "Yaqubov", 35, "80", "182");
            Console.WriteLine(person.ToString());
            Console.ReadLine(); 
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }

        public Person(string name, string surname, int age, string weight, string height)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;

        }
        public override string ToString()
        {
            return " My name is " + Name + ", surname is " + Surname + ", i am " + Age + " years old " + ", my weight is " + Weight + " kq " + " and my height is " + Height + " sm. ";

        }
    }

}