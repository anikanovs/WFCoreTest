using System;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace SolutionWFCoreTest
{
    public class MyWorkflowHost : IWorkflowHost
    {
        public IPersistenceProvider PersistenceStore { get; }
        public IDistributedLockProvider LockProvider { get; }
        public IWorkflowRegistry Registry { get; }
        public WorkflowOptions Options { get; }
        public IQueueProvider QueueProvider { get; }
        public ILogger Logger { get; }
        public event StepErrorEventHandler OnStepError;
        public event LifeCycleEventHandler OnLifeCycleEvent;        
        
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void ReportStepError(WorkflowInstance workflow, WorkflowStep step, Exception exception)
        {
            throw new NotImplementedException();
        }

        public Task<string> StartWorkflow(string workflowId, object data = null, string reference = null)
        {
            throw new NotImplementedException();
        }

        public Task<string> StartWorkflow(string workflowId, int? version, object data = null, string reference = null)
        {
            throw new NotImplementedException();
        }

        public Task<string> StartWorkflow<TData>(string workflowId, TData data = default(TData), string reference = null) where TData : class, new()
        {
            throw new NotImplementedException();
        }

        public Task<string> StartWorkflow<TData>(string workflowId, int? version, TData data = default(TData), string reference = null) where TData : class, new()
        {
            throw new NotImplementedException();
        }

        public Task PublishEvent(string eventName, string eventKey, object eventData, DateTime? effectiveDate = null)
        {
            throw new NotImplementedException();
        }

        public void RegisterWorkflow<TWorkflow>() where TWorkflow : IWorkflow
        {
            throw new NotImplementedException();
        }

        public void RegisterWorkflow<TWorkflow, TData>() where TWorkflow : IWorkflow<TData> where TData : new()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SuspendWorkflow(string workflowId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResumeWorkflow(string workflowId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TerminateWorkflow(string workflowId)
        {
            throw new NotImplementedException();
        }

        public Task<PendingActivity> GetPendingActivity(string activityName, string workerId, TimeSpan? timeout = null)
        {
            throw new NotImplementedException();
        }

        public Task ReleaseActivityToken(string token)
        {
            throw new NotImplementedException();
        }

        public Task SubmitActivitySuccess(string token, object result)
        {
            throw new NotImplementedException();
        }

        public Task SubmitActivityFailure(string token, object result)
        {
            throw new NotImplementedException();
        }
    }
}