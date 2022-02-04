using System.Reflection;
using Reflection;
using Reflection.Models;
using Reflection.Samples.DynamicInvocations;
using Reflection.Samples.DynamicReflection;



var getStarted = new GetStarted();

getStarted.AssemblyInfo();
getStarted.TypesAndPropertiesOfAssembly();

GetStarted.AccessToPrivates();
GetStarted.CastInstanceAndInvokeMethod();
//GetStarted.ExternalAssembly(@"C:\...\...\fileName.exe");



// *****   DYNAMIC REFLECTION DEMO   *****
var assembly = Assembly.Load(new AssemblyName("Reflection"));
var objectType = assembly.GetType("Reflection.Models.Student");

//var objectInstance = Activator.CreateInstance(typeof(Student));
var objectInstance = (Student)Activator.CreateInstance(objectType!);


dynamic student = new ExtendedObject(objectInstance);
var staticResult = (string)student.Community("Full Stack Development");
Console.WriteLine(staticResult);

var results = DynamicRequest.Run();
//foreach (var result in results) { TODO }



// exit:
Console.ReadKey();