using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class NewIe
    {

    }
    public interface IHander
    {
        event EventHandler Handler;
    }

    public class Hander : IHander
    {
        public Hander()
        {
            Handler1 += SayHellow;
        }

        private void SayHellow(object sender, EventArgs e)
        {
            string name = "";
        }

        public event EventHandler Handler1;

        event EventHandler IHander.Handler
        {
            add { Handler1 += value; }
            remove { Handler1 -= value; }
        }
        public void hand()
        {
            Handler1?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Cb1
    {
        public Cb1(Hander d)
        {
            IHander h = d;
            h.Handler += bin;
        }

        private void bin(object sender, EventArgs e)
        {
            string aaa = "hander input";
        }
    }
    public class Pross
    {
        private readonly IHander aaa;

        public void sa()
        {
            Hander d = new Hander();
            d.Handler1 += aqaqqqq;
            d.hand();
        }
        private void aqaqqqq(object sender, EventArgs e)
        {
            string aaa = "hander input";
        }
    }
}
