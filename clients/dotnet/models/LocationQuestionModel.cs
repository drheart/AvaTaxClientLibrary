using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Information about questions that the local jurisdictions require for each location
    /// </summary>
    public class LocationQuestionModel
    {
        /// <summary>
        /// The unique ID number of this location setting type
        /// </summary>
        public Int32 id { get; set; }

        /// <summary>
        /// This is the prompt for this question
        /// </summary>
        public String question { get; set; }

        /// <summary>
        /// If additional information is available about the location setting, this contains descriptive text to help
        ///             you identify the correct value to provide in this setting.
        /// </summary>
        public String description { get; set; }

        /// <summary>
        /// If available, this regular expression will verify that the input from the user is in the expected format.
        /// </summary>
        public String regularExpression { get; set; }

        /// <summary>
        /// If available, this is an example value that you can demonstrate to the user to show what is expected.
        /// </summary>
        public String exampleValue { get; set; }

        /// <summary>
        /// Indicates which jurisdiction requires this question
        /// </summary>
        public String jurisdictionName { get; set; }

        /// <summary>
        /// Indicates which type of jurisdiction requires this question
        /// </summary>
        public JurisdictionType? jurisdictionType { get; set; }

        /// <summary>
        /// Indicates the country that this jurisdiction belongs to
        /// </summary>
        public String jurisdictionCountry { get; set; }

        /// <summary>
        /// Indicates the state, region, or province that this jurisdiction belongs to
        /// </summary>
        public String jurisdictionRegion { get; set; }


    }
}