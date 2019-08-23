using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public interface IPerson
    {
        string GetPersonName();

        int this[int index] { get; set; }
        string Speakering(string speak);

        string name { get; set; }

        int age { get; set; }

        string Address { get; set; }
    }
    public interface ISpeaker
    {
        event EventHandler onSpeaker ;

    }
}
