using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Represents a form that can be filed with a tax authority.
    /// </summary>
    public class TaxAuthorityFormModel
    {
        /// <summary>
        /// The unique ID number of the tax authority.
        /// </summary>
        public Int32 taxAuthorityId { get; set; }

        /// <summary>
        /// The form name of the form for this tax authority.
        /// </summary>
        public String formName { get; set; }



        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
		{
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
		}
    }
}
