﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigiApiCsharpExample
{
    public class BloombergInstrument
    {
        [JsonProperty("figi")]
        public string figi { get; set; }
        [JsonProperty("securityType")]
        public string SecurityType { get; set; }
        [JsonProperty("marketSector")]
        public string MarketSector { get; set; }
        [JsonProperty("ticker")]
        public string Ticker { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("uniqueID")]
        public string uniqueID { get; set; }
        [JsonProperty("exchCode")]
        public string exchCode { get; set; }
        [JsonProperty("shareClassFIGI")]
        public string ShareClassFIGI { get; set; }
        [JsonProperty("compositeFIGI")]
        public string CompositeFIGI { get; set; }
        [JsonProperty("securityType2")]
        public string SecurityType2 { get; set; }
        [JsonProperty("securityDescription")]
        public string SecurityDescription { get; set; }
        [JsonProperty("uniqueIDFutOpt")]
        public string uniqueIDFutOpt { get; set; }

        [JsonProperty("tickerComplete")]
        public string TickerComplete
        {
            get { return MarketSector == "Equity" ? string.Format("{0} {1} {2}", Ticker, exchCode, MarketSector) : string.Format("{0} {1}", Ticker, MarketSector); }

        }

    }
}
