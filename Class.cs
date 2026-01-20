namespace WebApplication1
{
    public class Class
    {
        int age = 0;
        string name = "John";
        DateTime birthDate = new DateTime(1990, 1, 1);
        public Class()

        {
          
        }



        public void Deconstruct(out int age, out string name, out DateTime birthDate)
        {
            age = this.age;
            name = this.name;
            birthDate = this.birthDate;
        }
    }
}
