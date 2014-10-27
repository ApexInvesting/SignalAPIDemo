using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {

    public partial class API {

        /// <summary>
        /// Records the fact that a trade has been closed
        /// </summary>
        public Signals_CloseTradeResponse Signals_CloseTrade(Signals_CloseTradeRequest request) {
            throw new NotImplementedException();
        }

        public class Signals_CloseTradeRequest {

            /// <summary>
            /// The id of the trade being closed.
            /// </summary>
            public Guid TradeId;

            public decimal ExitedPrice;
            public DateTime ExitedAt;

            /// <summary>
            /// Whether this trade is closed by holding it to expiration
            /// </summary>
            public bool IsExitAtExpiration;
        }

        public class Signals_CloseTradeResponse {

        }
    }
}
