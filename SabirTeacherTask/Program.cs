namespace SabirTeacherTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st= new Student("Alik","Shukurov", 20);
            Employee ep = new Employee("Samuray", "Katanov", 22);
           // st.GetInfo();
            ep.GetInfo();
        }
    }
}
