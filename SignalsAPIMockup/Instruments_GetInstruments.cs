using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {
    public partial class API {

        // Gets all instruments, stocks, futures, currency pairs, EXCEPT Nadex instruments
        public GetInstrumentsResponse Instruments_GetInstruments(GetInstrumentsRequest request) {
            throw new NotImplementedException();
        }

        public class GetInstrumentsRequest {
        }

        public class GetInstrumentsResponse {
            public InstrumentDefinition[] Instruments;
        }

        public class InstrumentDefinition {
            public Guid Id;
            public InstrumentTypes InstrumentType;
            public string NinjaTraderSymbol;
        }

        public enum InstrumentTypes {
            Stock,
            CurrencyPair,
            FutureContract
        }
    }
}
