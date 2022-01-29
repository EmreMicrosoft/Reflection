using Reflection;

var getStarted = new GetStarted();

getStarted.AssemblyInfo();
getStarted.TypesAndPropertiesOfAssembly();

GetStarted.AccessToPrivates();
GetStarted.CastInstanceAndInvokeMethod();
GetStarted.ExternalAssembly(@"C:\...\...\fileName.exe");

Console.ReadKey();