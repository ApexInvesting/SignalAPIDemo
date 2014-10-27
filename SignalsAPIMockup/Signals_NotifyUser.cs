using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {

    public partial class API {

        /// <summary>
        /// Records the fact that a message (notification) was sent to the users
        /// </summary>
        /// <remarks>Does this satisfy the requirements for the "headsup" and "breakout" entries being recorded at the moment?</remarks>
        public Signals_NotifyUserResponse Signals_NotifyUser(Signals_NotifyUserRequest request) {
            throw new NotImplementedException();
        }

        public class Signals_NotifyUserRequest {

            public Guid SignalId;
            public string HeaderText;
            public string Text;
        }

        public class Signals_NotifyUserResponse {

        }

    }
}
