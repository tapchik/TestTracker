using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTracker.Models
{
    public struct TestCase
    {
        public int ShortId;
        public string Title;
        public string Idea;
        public string ExpectedResult;
        public int QtyOfSteps;

        public string FullId
            { get { return $"TC{ShortId}"; } }

        public String Representation
            { get { return $"{FullId}: {Title} ({QtyOfSteps})"; } }
    }
}
