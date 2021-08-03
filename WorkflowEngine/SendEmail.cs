using System;

namespace WorkflowEngine
{
    public class SendEmail : IActivities
    {
        public void Execute(Commands cmd)
        {
            Console.WriteLine("Send an email to the owner of the video" +
                              " notifying them that the video started processing.");
        }
    }
}