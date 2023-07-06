using System;
using System.Diagnostics;






//Task 1
Process process = new Process();

process.StartInfo.FileName = "Notepad.exe";

process.Start();

process.WaitForExit();

Console.WriteLine("Hello, World!");

Console.WriteLine("Exit" + process.ExitCode);

//Task 2

Process process1= new Process();

process1.StartInfo.FileName = "Notepad.exe";

process1.Start();

Console.WriteLine("Ожидание или Завершение  (0 Ожидание \n 1 Закрытие)");
string Choice = Console.ReadLine();

if (Choice == "0" )
{
    process1.WaitForExit();
    Console.WriteLine("Exit " + process1.ExitCode);
}
else if(Choice== "1" )
{
    
    process1.Kill();
    Console.WriteLine("Kill " + process1.ExitCode);
}
else
{
    Console.WriteLine("Некорректный Ввод");
}