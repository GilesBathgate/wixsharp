//css_dir ..\..\;
//css_ref Wix_bin\SDK\Microsoft.Deployment.WindowsInstaller.dll;
//css_ref System.Core.dll;
//css_ref WixSharp.UI.dll;
using System;
using WixSharp;

class Script
{
    static public void Main()
    {
        var project = new ManagedProject("MyProduct",
                          new Dir(@"C:\MyCompany\MyProduct", new Files(@"files\*.*")));

        project.UI = WUI.WixUI_ProgressOnly;
        project.ManagedUI = ManagedUI.Default;

        Compiler.PreserveTempFiles = true;
        Compiler.BuildMsi(project);
    }
}