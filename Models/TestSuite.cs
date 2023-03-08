using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTracker.Models
{
    public struct TestSuite
    {
        public int ShortId;
        public string Title;
        public int QtyOfTestCases;

        public string FullId
            { get { return $"TS{ShortId}"; } }

        public string Representation
            { get { return $"{FullId}: {Title} ({QtyOfTestCases})"; } }
    }
}
