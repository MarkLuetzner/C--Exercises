using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Windows.Storage;
using Windows.Storage.Streams;
using System.IO;
using System.Runtime.Serialization;

namespace p_552
{
    [DataContract(Namespace = "p_552")]
    class Guy
    {
        public Guy(string name, int age, decimal cash)
        {
            Name = name;
            Age = age;
            Cash = cash;
            TrumpCard = Card.RandomCard();
        }

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public int Age { get; private set; }

        [DataMember]
        public decimal Cash { get; private set; }

        [DataMember(Name = "MyCard")]
        public Card TrumpCard { get; private set; }

        public override string ToString()
        {
            return String.Format("My name is {0}, I'm {1}, I have {2} bucks, " + "and my trump card is {3}", Name, Age, Cash, TrumpCard);
        }

    }
}
