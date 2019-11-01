using System.Collections.Generic;
using System.IO;

using SingleResponsibilityPrinciple.Contracts;

namespace SingleResponsibilityPrinciple
{
    public class StreamTradeDataProvider : ITradeDataProvider
    {
        public StreamTradeDataProvider(Stream stream)
        {
            this.stream = stream;
        }

        public IEnumerable<string> GetTradeData()
        {
            var tradeData = new List<string>();
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tradeData.Add(line);
                }
            }
            return tradeData;
        }

        private readonly Stream stream;
    
    public IEnumerable<string> URLGetTradeData()
        {
           var tradeData = new List (); 
            var client = new WebClient(); 
            using (var stream = client.OpenRead(url)) 
            using (var reader = new StreamReader(stream)) 
            { 
                string line; 
                while ((line = reader.ReadLine()) != null) 
                { 
                    tradeData.Add(line); 
                } 
            } 
            return tradeData;
        }
    }
}
