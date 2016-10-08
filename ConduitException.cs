using System;

namespace Phabricator.Conduit
{
    public class ConduitException : ApplicationException
    {
        public string ConduitErrorCode { get; private set; }

        public string ConduitErrorInfo { get; private set; }

        public ConduitException(string errorCode, string errorInfo)
            : base(errorCode + ": " + errorInfo)
        {
            this.ConduitErrorCode = errorCode;
            this.ConduitErrorInfo = errorInfo;
        }
    }
}

