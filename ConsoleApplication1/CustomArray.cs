using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CustomArray
    {
        List<string> mList = new List<string>();

        public virtual void Add(string element)
        {
            mList.Add(element);
        }

        public virtual void AddAll(IEnumerable<string> elements)
        {
            foreach (var item in elements)
            {
                Add(item);
            }
        }
    }

    class SubCustomArray : CustomArray, ICloneable
    {
        int Count = 0;

        public override void Add(string element)
        {
            base.Add(element);
            Count++;
        }

        public override void AddAll(IEnumerable<string> elements)
        {
            base.AddAll(elements);
            Count = Count + elements.Count();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
