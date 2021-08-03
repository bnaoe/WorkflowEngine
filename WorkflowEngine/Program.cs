using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{

    public class WorkflowEngine
    {
        private readonly IList<IActivities> _activities;


        public WorkflowEngine()
        {
            _activities = new List<IActivities>();
        }

        public void Run()
        {
            foreach (var a in _activities)
            {
                a.Execute(new Commands());
            }
        }

        public void AddActivities(IActivities activity)
        {
            _activities.Add(activity);
        }

    }

    public interface IActivities
    {
        void Execute(Commands cmd);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkflowEngine();
            workflow.AddActivities(new UploadVideo());
            workflow.AddActivities(new CallWebSercice());
            workflow.AddActivities(new SendEmail());
            workflow.AddActivities(new ChangeStatus());
            workflow.Run();
        }
    }
}
