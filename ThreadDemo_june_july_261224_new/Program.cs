namespace ThreadDemo_june_july_261224_new
{
    class myclass
    {
        public void method1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("# method1 i:" + i+" Thread name:"+Thread.CurrentThread.Name);
                Thread.Sleep(100);
            }
        }
        public void method2()
        {
            for (int j = 0; j < 50; j++)
            {
                Console.WriteLine("* method2 j:" + j + " Thread name:" + Thread.CurrentThread.Name);
                Thread.Sleep(100);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########### main start ################");
            Console.WriteLine("in main Thread name:"+Thread.CurrentThread.Name);
            myclass mobj = new myclass();
            Thread t1 = new Thread(mobj.method1);
            Thread t2 = new Thread(mobj.method2);
            t1.Name = "T1";
            t2.Name = "T2";
            Console.WriteLine("T1 IsBackground:"+t1.IsBackground);
            Console.WriteLine("T2 IsBackground:" + t2.IsBackground);
            t1.IsBackground = true;
            t2.IsBackground = true;
            Console.WriteLine("T1 IsBackground:" + t1.IsBackground);
            Console.WriteLine("T2 IsBackground:" + t2.IsBackground);
            t1.Start();
            t2.Start();
            Console.WriteLine("######## main end #######");
        }
    }
}
