namespace MyInterface
{
    interface IProject
    {
        //properties
        public string Name { get; set;}
        public double Time { get; set;}
        //methods
        public string Description();
    }
    internal class Program
    {
        class CrochetProject : IProject
        {
            public string Name { get; set;}
            public double Time { get; set;}
            public string Hook { get; set;}

            public CrochetProject()
            {
                Name = string.Empty;
                Time = 0;
                Hook = string.Empty;
            }
            public CrochetProject(string name, double time, string hook)
            {
                Name = name;
                Time = time;
                Hook = hook;
            }

            public string Description()
            {
                return Name + " takes " + Time + " hours.";
            }
        }
        static void Main(string[] args)
        {
            CrochetProject myProject = new CrochetProject("Hat",1.5,"L-8mm");
            Console.WriteLine(myProject.Description());
        }
    }
}
