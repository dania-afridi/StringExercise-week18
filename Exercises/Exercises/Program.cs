// See https://aka.ms/new-console-template for more information

//######################### EXERCISES ###################################//

//********* 01: Change String Value into string Array **************//
string text1 = "If we want to restrict this feature, we need to set a flag";
string[] text1Array = text1.Split(' ');
foreach (string str in text1Array)
{
    Console.Write(str + ", ");
}
Console.WriteLine("\n\n");

//********* 02: Change String Value into string Array **************//
string text2 = "If,we,want,to,restrict,this,feature,we,need,to,set,a,flag";
string[] text2Array = text2.Split(',');
foreach (string str in text2Array)
{
    Console.Write(str + ", ");
}
Console.WriteLine("\n\n");

//********* 03: Change String Value into string Array containing no spaces **************// "combine trim and split"
string text3 = " If ,  we ,want,to, restrict , this , feature,we, need  ,to ,set,a, flag ";
string newText = text3.Trim();
Console.WriteLine(newText);
string[] text3Array = newText.Split(' ');
foreach (string str in text3Array)
{
    Console.Write(str);
}
Console.WriteLine("\n\n");

//********* 04: Change String Value into new string by removing first three words **************// "Substring"
string text4 = "If we want to restrict this feature, we need to set a flag";
string subText = text4.Substring(11);
Console.WriteLine(subText + "\n\n");

//********* 05: Find the index for first char 's' in the String **************//
string text5 = "If we want to restrict this feature, we need to set a flag";
int indexOfs = text5.IndexOf('s');
Console.WriteLine("Index of first occurance of 's' is: " + indexOfs + "\n");

Console.ReadLine();

