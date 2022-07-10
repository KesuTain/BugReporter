using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utilities.BugReporter
{
    public class BugReportHandler
    {
        private IBugSender _sendHandler;

        public BugReportHandler(IBugSender sendHandler)
        {
            _sendHandler = sendHandler;
        }

        public void SendBugReport(IBugModel bugReport)
        {
            _sendHandler.SendData(bugReport);
        }

    }
}