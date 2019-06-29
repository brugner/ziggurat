using System;
using System.Runtime.Serialization;

namespace Corlib.Exceptions
{
   class ParametersNotFoundException : Exception
   {
      public ParametersNotFoundException()
      {
      }

      public ParametersNotFoundException(string message) : base(message)
      {
      }

      public ParametersNotFoundException(string message, Exception innerException) : base(message, innerException)
      {
      }

      protected ParametersNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
      {
      }
   }
}
