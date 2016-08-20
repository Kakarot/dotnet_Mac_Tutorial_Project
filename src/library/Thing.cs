using System;
using static Newtonsoft.Json.JsonConvert;

namespace Library
{
    public class Thing
    {
        //Cool
        public int Get(int left, int right) =>
            DeserializeObject<int>($"{left + right}");
        
    }
}
