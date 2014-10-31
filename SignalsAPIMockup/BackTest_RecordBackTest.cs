using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalsAPIMockup {

    public partial class API {

        /// <summary>
        /// Records a backtest and its entire trade performance summary in a single upload
        /// </summary>
        public BackTests_RecordBackTestResponse BackTests_RecordBackTest(BackTests_RecordBackTestRequest request) {
            throw new NotImplementedException();
        }

        public class BackTests_RecordBackTestRequest {

            public BackTestDefinition Definition;
            public BackTestTrade[] Trades;

            /// <summary>
            /// Uniquely defines a backtest run
            /// </summary>
            public class BackTestDefinition {

                /// <summary>
                /// The id of the trading system being backtested
                /// </summary>
                public Guid TradingSystemId;

                /// <summary>
                /// The github commit id of the code version at the time of the test
                /// </summary>
                public byte[] CodeVersion;

                /// <summary>
                /// The id of the instrument being charted for the backtest.
                /// </summary>
                public Guid ChartedInstrumentId;


                public BarPeriodTypes BarPeriodType;
                public int BarPeriodValue1;
                public int BarPeriodValue2;
                public string BarSessionTemplateName;


                /// <summary>
                /// The first bar timestamp of the backtest
                /// </summary>
                public DateTime StartedAt;

                /// <summary>
                /// The last bar timestamp of the backtest
                /// </summary>
                public DateTime EndedAt;

                /// <summary>
                /// Json string containing the backtest parameters
                /// </summary>
                public string ConfigurationParameters;
            }

            public class BackTestTrade {

                /// <summary>
                /// The actual instrument that was traded (not necessarily the same as the charted instrument, as it may be a nadex contract)
                /// </summary>
                public Guid InstrumentId;

                /// <remarks>Negative value means the instrument was shorted</remarks>
                public int Quantity;

                public decimal EnteredPrice;
                public DateTime EnteredAt;

                /// <remarks>Required even when IsExitAtExpiration is True</remarks>
                public decimal ExitedPrice;

                /// <remarks>Required even when IsExitAtExpiration is True</remarks>
                public DateTime ExitedAt;

                /// <summary>
                /// Whether the trade was closed by holding to expiration
                /// </summary>
                public bool IsExitAtExpiration;
            }

            public enum BarPeriodTypes {
                Minute,
                Diagnostic
            }
        }

        public class BackTests_RecordBackTestResponse {
            public Guid Id;
        }
    }
}
