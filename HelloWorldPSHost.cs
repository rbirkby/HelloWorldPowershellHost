using System;
using System.Globalization;
using System.Management.Automation.Host;

internal class HelloWorldPSHost : PSHost
{
    private readonly HelloWorldHost _program;
    private readonly Guid _id = Guid.NewGuid();
    private readonly HelloWorldHostUserInterface _ui = new HelloWorldHostUserInterface();

    public HelloWorldPSHost(HelloWorldHost program)
    {
        _program = program;
    }

    public override CultureInfo CurrentCulture => CultureInfo.InvariantCulture;
    public override CultureInfo CurrentUICulture => CultureInfo.InvariantCulture;
    public override Guid InstanceId => _id;
    public override string Name => "HelloWorldHost";
    public override PSHostUserInterface UI => _ui;
    public override Version Version => new Version();

    public override void EnterNestedPrompt()
    {
        throw new NotImplementedException();
    }
    
    public override void ExitNestedPrompt()
    {
        throw new NotImplementedException();
    }

    public override void NotifyBeginApplication()
    {
        return;
    }

    public override void NotifyEndApplication()
    {
        return;
    }

    public override void SetShouldExit(int exitCode)
    {
        _program.ShouldExit = true;
        _program.ExitCode = exitCode;
    }
}

