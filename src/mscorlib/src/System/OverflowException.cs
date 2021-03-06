// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
**
** Purpose: Exception class for Arthimatic Overflows.
**
**
=============================================================================*/

namespace System {
 
    
    using System;
    using System.Runtime.Serialization;
    [System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class OverflowException : ArithmeticException {
        public OverflowException() 
            : base(Environment.GetResourceString("Arg_OverflowException")) {
            SetErrorCode(__HResults.COR_E_OVERFLOW);
        }
    
        public OverflowException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_OVERFLOW);
        }
        
        public OverflowException(String message, Exception innerException) 
            : base(message, innerException) {
            SetErrorCode(__HResults.COR_E_OVERFLOW);
        }

        protected OverflowException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }

    }

}
