using Newtonsoft.Json;
using System;

namespace HTTPClient
{
    class DataModelParent
    {
        public DataModel args;
        public String data;

        public DataModel parseString()
        {
            DataModel json = JsonConvert.DeserializeObject<DataModel>(data);
            return json;
        }
    }
}
