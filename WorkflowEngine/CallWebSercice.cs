using System;

namespace WorkflowEngine
{
    public class CallWebSercice : IActivities
    {
        public void Execute(Commands cmd)
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding " +
                              "service to tell them you have a video ready for encoding.");
        }
    }
}