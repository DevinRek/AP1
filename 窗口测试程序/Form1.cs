using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test1;
using Await;

namespace 窗口测试程序
{
    delegate int NumberChanger(int n);
    public partial class Form1 : Form
    {
        int num = 10;
        public int AddNum(int p)
        {
            num += p;
            return num;
        }

        public int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public int getNum()
        {
            return num;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public int? ConToIntNull(object value)
        {
            return Convert.ToInt32(value);
        }
        Hander h = new Hander();
        Await.Async async = new Async();
        private void Button2_Click(object sender, EventArgs e)
        {
            Await.Async.Main();
            //h.Handler1 -= aaa; //取消委托aaa
            //h.Handler1 -= bbb;
            //h.hand();          //执行委托
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            h.Handler1 += aaa;    //添加委托事件aaa
            h.Handler1 += bbb;
            h.hand();               //执行委托





            //onSpeaker1 u = new onSpeaker1();
            //string arr = "";
            //foreach (var i in u.arr)
            //{
            //    u[2] = 666;
            //    arr += i;
            //}
            //MessageBox.Show(arr);
            //Func<int, int> add = aq => aq + 10;
            //Func<int, int> num = aq => add(25)*aq;
            //int a121 = add(25);
            //int a211 = num(5);
            //NumberChanger nc1 = new NumberChanger(AddNum);
            //NumberChanger nc2 = new NumberChanger(MultNum);
            //// 使用委托对象调用方法
            //int aa1a = nc1(25);
            //int bbb = nc2(5);
            //Func<string, string> select = (str) => str.ToUpper();

            //Func<int, int, int> Max = (a1, a2) => a1 + a2;
            //int[] list = { 0, 1, 2, 3, 7, 2, 11 };
            //var ma = list.Where((a1, a2) => a1 > a2).Select(a1 => a1);


            //string[] words = { "orange", "apple", "Article", "elephant" };

            //var ww = words.Select(str => str.ToUpper());


            //Pet[] pets = { new Pet { Name="Barley", Age=10 },
            //       new Pet { Name="Boots", Age=4 },
            //       new Pet { Name="Whiskers", Age=6 } };

            //// Determine whether all pet names 
            //// in the array start with 'B'.
            //IEnumerable<Pet> pettttt = pets.Where(p => p.Age > 4); //Enumerable类型
            //List<Pet> li = pettttt.ToList();
            //var a = li.First(aaa => aaa.Age > 5);
            ////aaa();
        }
        public void aaa(object obgj, EventArgs e)
        {
            MessageBox.Show("111");
            MessageBox.Show("111");
        }
        public void bbb(object obgj, EventArgs e)
        {
            MessageBox.Show("a");
            MessageBox.Show("啊");
        }

     
    }
    public enum car
    {
        san = 0,
        today = 1,
        aaa = 2

    }
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Person
    {
        public string name { get; set; }
        public Person(string name)
        {
            this.name = name;
        }
        public Person()
        {

        }
    }
}
