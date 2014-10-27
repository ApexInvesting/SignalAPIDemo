using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {

    public partial class API {

        public Signals_CreateSignalResponse Signals_CreateTrade(Signals_CreateSignalRequest request) {
            throw new NotImplementedException();
        }

        public class Signals_CreateSignalRequest {

            /// <summary>
            /// The id of the system that this signal is for
            /// </summary>
            public Guid SystemId;

            /// <summary>
            /// The id of the main instrument (such as an underlying) that the system is being run on
            /// </summary>
            public Guid ChartedInstrumentId;
        }

        public class Signals_CreateSignalResponse {

            public Guid SignalId;
        }
    }
}
