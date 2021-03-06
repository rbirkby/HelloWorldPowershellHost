using System.Management.Automation.Runspaces;
using System.Management.Automation;

internal class HelloWorldHost
{
    public bool ShouldExit { get; set; }
    public int ExitCode { get; set; }

    private static void Main()
    {
        var myHost = new HelloWorldPSHost(new HelloWorldHost());

        using (Runspace myRunSpace = RunspaceFactory.CreateRunspace(myHost))
        {
            myRunSpace.Open();

            using (var powershell = PowerShell.Create())
            {
                powershell.Runspace = myRunSpace;

                powershell.AddScript("Write-Warning 'Hello World'; &cmd /c Echo 'Hello World' 1`>`&2");
                powershell.AddCommand("out-default");
                powershell.Commands.Commands[0].MergeMyResults(PipelineResultTypes.Error, PipelineResultTypes.Output);
                powershell.Invoke();
            }
        }
    }
}

