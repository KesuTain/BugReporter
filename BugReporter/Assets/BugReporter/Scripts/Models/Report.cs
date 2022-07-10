using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities.BugReporter;

namespace Example
{
    [System.Serializable]
    public class Report : IBugModel
    {
        public string BugName;
        public string Description;
        public Report(string bugName, string description)
        {
            BugName = bugName;
            Description = description;
        }

        public string GetBugReport()
        {
            string bug = BugName + " " + Description;
            return bug;
        }
    }
}
