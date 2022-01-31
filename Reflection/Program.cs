using System.Reflection;
using Reflection;
using Reflection.Models;
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
var objectInstance = (Student)Activator.CreateInstance(objectType!);

//var objectInstance = Activator.CreateInstance(typeof(Student));

dynamic student = new ExtendedObject(objectInstance);
var result = (string)student.Community("Full Stack Development");

Console.WriteLine(result);



// exit:
Console.ReadKey();