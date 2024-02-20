/*泛型*/
//泛型接口

namespace Generic3002 {

    class Program {
        static void Main(string[] args) {
            //Student<int> student = new Student<int>() { ID = 1, Name = "Authur"};
            //Console.WriteLine($"ID is {student.ID}.Name is {student.Name}.");
            //Student<ulong> student = new Student<ulong>() { ID = 1000000000000000001, Name = "Jhon" };
            Student student = new Student() { ID = 1000000000000000001,Name = "Jhon" };
            Console.WriteLine($"ID is {student.ID}.Name is {student.Name}.");
        }
    }
    
    interface IUnique<TId> {
        TId ID { get; set; }
    }

    //class Student<TId> : IUnique<TId> {
    //    public TId ID { get; set; }
    //    public string Name { get; set; }
    //}
    class Student : IUnique<ulong> {
        public ulong ID { get; set; }
        public string Name { get; set; }
    }
}