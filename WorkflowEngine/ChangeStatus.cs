using System;

namespace WorkflowEngine
{
    public class ChangeStatus : IActivities
    {
        public void Execute(Commands cmd)
        {
            Console.WriteLine("Change Status to Processing.");
        }
    }
}