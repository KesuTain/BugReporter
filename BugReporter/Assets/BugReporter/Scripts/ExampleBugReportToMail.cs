using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities.BugReporter;
using TMPro;

namespace Example
{
    public class ExampleBugReportToMail : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _name;
        [SerializeField] private TMP_InputField _decription;
        [SerializeField] private TMP_InputField _mail;
        [SerializeField] private TMP_InputField _mailPassword;
        [SerializeField] private TMP_InputField _recipientMail;

        public void SendBugReportToMail()
        {
            SenderToMail senderToMail = new SenderToMail(_mail.text, _mailPassword.text, _recipientMail.text);

            Report report = new Report(_name.text, _decription.text);

            senderToMail.SendData(report);
        }
    }
}