using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelMapping.App.Component
{
    public class AutoMapping
    {
        public string FilePath { get; set; }
        public List<Channel> ChannelList { get; set; }
        public AutoMapping() { }
        public void BuildFromFile(string filePath)
        {
            FilePath = filePath;
        }

        public void SearchPairs()
        {

        }
    }
}
