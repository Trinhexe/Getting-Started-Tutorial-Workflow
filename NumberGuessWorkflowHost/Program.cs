using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;
using NumberGuessWorkflowActivities;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumberGuessWorkflowHost
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new WorkflowHostForm());
        }
    }
}
