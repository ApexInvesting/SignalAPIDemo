using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {

    public partial class API {

        /// <summary>
        /// Used to create a trading system (or at least make sure it exists in the database)
        /// The id of the trading system will be used to index backtests and signals
        /// </summary>
        public TradingSystems_GetOrCreateResponse TradingSystems_GetOrCreate(TradingSystems_GetOrCreateRequest request) {
            throw new NotImplementedException();
        }

        public class TradingSystems_GetOrCreateRequest {
            public string TradingSystemName;
        }

        public class TradingSystems_GetOrCreateResponse {

            /// <summary>
            /// The id of the trading system you wanted to get or create
            /// </summary>
            public Guid TradingSystemId;

            /// <summary>
            /// Whether the trading system is created new, or already existed in the database
            /// </summary>
            public bool IsCreatedNew;
        }

    }
}
