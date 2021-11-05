using System;
using System.Net.Mime;
using WorkflowCore.Interface;

namespace SolutionWFCoreTest
{
    public class MyWorkflow : IWorkflow 
    {
        public MyWorkflow()
        {
            
        }

        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith<HelloWorldStep>()
                .Then<Task2>()
                .Then<Task3>();
        }

        public string Id { get; }
        public int Version { get; }
    }
}