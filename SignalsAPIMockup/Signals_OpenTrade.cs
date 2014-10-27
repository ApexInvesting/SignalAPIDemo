using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {

    public partial class API {

        /// <summary>
        /// Records the fact that a position has been opened for a signal
        /// </summary>
        public Signals_OpenTradeResponse Signals_OpenTrade(Signals_OpenTradeRequest request) {
            throw new NotImplementedException();
        }

        public class Signals_OpenTradeRequest {

            public Guid SignalId;
            public int Quantity;
            public decimal EnteredPrice;
            public DateTime EnteredAt;
        }

        public class Signals_OpenTradeResponse {

            public Guid TradeId;
        }
    }
}
