using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    class Lake : IEnumerable<int>
    {
        public List<int> Stones { get; set; }

        public Lake(List<int> stones)
        {
            Stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int subtractPositions = 0;
            switch (Stones.Count % 2)
            {
                case 0: subtractPositions = 1; break;
                case 1: subtractPositions = 2; break;
            }
            for (int i = 0; i < Stones.Count; i += 2)
            {
                yield return Stones[i];
            }
            for (int i = Stones.Count - subtractPositions; i >= 0; i -= 2)
            {
                yield return Stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
