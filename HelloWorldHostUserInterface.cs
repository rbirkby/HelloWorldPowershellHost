using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Host;

internal class HelloWorldHostUserInterface : PSHostUserInterface
{
    public override PSHostRawUserInterface RawUI => null;

    public override Dictionary<string, PSObject> Prompt(string caption, string message, System.Collections.ObjectModel.Collection<FieldDescription> descriptions)
    {
        throw new NotImplementedException();
    }

    public override int PromptForChoice(string caption, string message, System.Collections.ObjectModel.Collection<ChoiceDescription> choices, int defaultChoice)
    {
        throw new NotImplementedException();
    }

    public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName)
    {
        throw new NotImplementedException();
    }

    public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options)
    {
        throw new NotImplementedException();
    }

    public override string ReadLine()
    {
        return Console.ReadLine();
    }

    public override System.Security.SecureString ReadLineAsSecureString()
    {
        throw new NotImplementedException();
    }

    public override void Write(string value)
    {
        Console.Write(value);
    }

    public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
    {
        Console.Write(value);
    }

    public override void WriteDebugLine(string message)
    {
        Console.WriteLine($"DEBUG: {message}");
    }

    public override void WriteErrorLine(string value)
    {
        Console.WriteLine($"ERROR: {value}");
    }

    public override void WriteLine()
    {
        Console.WriteLine();
    }

    public override void WriteLine(string value)
    {
        Console.WriteLine(value);
    }

    public override void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
    {
        Console.WriteLine(value);
    }

    public override void WriteProgress(long sourceId, ProgressRecord record)
    {
    }

    public override void WriteVerboseLine(string message)
    {
        Console.WriteLine($"VERBOSE: {message}");
    }

    public override void WriteWarningLine(string message)
    {
        Console.WriteLine($"WARNING: {message}");
    }
}
