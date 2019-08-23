using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class onSpeaker1 : IPerson
    {
        StringBuilder Message = new StringBuilder();
        public int PersonNum { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string Address { get; set; }

        public int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public onSpeaker1()
        {
            this.age = 12;
            this.Address = "江苏省苏州市";
            this.name = "张三";
        }
        public string GetPersonName()
        {
            this.name = "zhangsan";
            return this.name;
        }


        public static int GetPersonNum()
        {

            return 1;
        }
        public static void namename()
        { }
        private string br = "\r\t" + "\r\n";

        public string Speakering(string speak)
        {
            Message.Append("My name is" + name + br);
            Message.Append("My Address is" + Address + br);
            Message.Append("My Age is" + age + br);
            Message.Append(speak);
            return Message.ToString();
        }

        public static void buy()
        {

        }
        public static void sssss1()
        {

        }

        public delegate void MrEventHandler();
        MrEventHandler mrEventHandler = new MrEventHandler(buy);
        public void say()
        {
            mrEventHandler += sssss1;
            mrEventHandler();
        }
    }
}
