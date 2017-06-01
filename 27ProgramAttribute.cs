# C-Simples

 class Program
    {
        static void Main(string[] args)
        {
        }
        [SampleAttribute("")]
        class A
        {

        }
    }
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
        public class SampleAttribute : Attribute
        {
            //...
            private string v;

            public SampleAttribute(string v)
            {
                this.v = v;
            }
        }
