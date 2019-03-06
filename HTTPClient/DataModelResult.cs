using Newtonsoft.Json;
using System;

namespace HTTPClient
{
    class DataModelResult
    {
        public string Id { get; set; }
        public string LinkedId { get; set; }
        public double DataResult1 { get; set; }
        public string DataResult2 { get; set; }

        public string toString()
        {
            return $"\r\nId: {Id}\r\nLinkedId: {LinkedId}\r\nData Result 1: {DataResult1}\r\nData Result 2: {DataResult2}";
        }

    }
}
