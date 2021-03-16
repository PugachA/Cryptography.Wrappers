using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cryptography.Wrappers.Certificates
{
    /// <summary>
    /// Certificate search criteria
    /// </summary>
    public class SearchCriteria
    {
        /// <summary>
        /// Certificate find type
        /// </summary>
        public X509FindType FindType { get; }

        /// <summary>
        /// Value to find a certificate
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// Create SearchCriteria
        /// </summary>
        /// <param name="findType"></param>
        /// <param name="value"></param>
        public SearchCriteria(X509FindType findType, object value)
        {
            this.FindType = findType;
            this.Value = value;
        }
    }
}
