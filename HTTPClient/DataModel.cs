using System;

namespace HTTPClient
{
    public class DataModel
    {
        public int Id;
        public int Data1 { get; set; }
        public double Data2 { get; set; }
        public string Data3 { get; set; }
        public Boolean Data4 { get; set; }
        public int Data5 { get; set; }

        public DataModel(int field1, double field2, string field3, Boolean field4, int field5, int id)
        {
            Data1 = field1;
            Data2 = field2;
            Data3 = field3;
            Data4 = field4;
            Data5 = field5;
            this.Id = id;
        }

        public string toString()
        {
            return $"Data 1: {Data1}\r\nData 2: {Data2}\r\nData 3: {Data3}\r\nData 4: {Data4}\r\nData 5: {Data5}\r\nID: {Id}\r\n";
        }

    }
}
