﻿using System.ServiceModel;

namespace PowerShellTools.Common.ServiceManagement.IntelliSenseContract
{
    /// <summary>
    /// Powershell service.
    /// </summary>
    [ServiceContract(CallbackContract = typeof(IIntelliSenseServiceCallback))]
    public interface IPowershellIntelliSenseService
    {
        [OperationContract]
        void RequestCompletionResults(string scriptUpToCaret, int carePosition, long triggerTimeTicks);

        [OperationContract]
        void GetDummyCompletionList(string scriptUpToCaret, int carePosition);

        [OperationContract]
        ParseErrorItem[] GetParseErrors(string spanText);
    }
}
