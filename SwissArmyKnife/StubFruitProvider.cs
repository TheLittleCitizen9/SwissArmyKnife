using System;
using System.Collections.Generic;
using System.Text;
using TestMe;

namespace SwissArmyKnife
{
    public class StubFruitProvider : IFruitProvider
    {
        public IEnumerable<IFruit> Provide()
        {
            return new List<IFruit>() { new Fruit("orange", 1), new Fruit("lemon", 2)};
        }
    }
}
