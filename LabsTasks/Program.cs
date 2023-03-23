// See https://aka.ms/new-console-template for more information



using LabsTasks.Lab3;

var path = "C:\\Users\\aim\\source\\repos\\LabsTasks\\LabsTasks\\test.txt";

using (StreamWriter writer = File.CreateText(path))
{
    await writer.WriteLineAsync("First line of example");
    await writer.WriteLineAsync("and second line");
}


var work = new WorkInCompany();

IndividWork.DoWorkWOthStudent();