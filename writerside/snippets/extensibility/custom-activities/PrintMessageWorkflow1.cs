using Elsa.Workflows;
using Elsa.Workflows.Contracts;

public class PrintMessageWorkflow : WorkflowBase
{
    protected override void Build(IWorkflowBuilder builder)
    {
        var message = builder.WithVariable<string>("Message", "Hello, World!");

        builder.Root = new PrintMessage
        {
            Message = new(context => $"The message is: {message.Get(context)}")
        };
    }
}