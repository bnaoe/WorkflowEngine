using System;

namespace WorkflowEngine
{
    public class UploadVideo : IActivities
    {
        public void Execute(Commands cmd)
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}