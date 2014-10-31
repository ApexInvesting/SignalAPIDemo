using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {

    public partial class API {

        public Signals_RecordEventResponse Signals_RecordEvent(Signals_RecordEventRequest request) {
            throw new NotImplementedException();
        }

        public class Signals_RecordEventRequest {

            public Guid SignalId;
            public DateTime At;
            public string Name;
            public string Value;
        }

        public class Signals_RecordEventResponse {
        }
    }
}
