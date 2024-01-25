using Encrypter;
using System;
using System.Text;
using System.Collections;
using System.Linq.Expressions;
using System.Text;
using System.IO;

Console.ForegroundColor = ConsoleColor.Green;

//Console.OutputEncoding = Encoding.Unicode;
//var encrypter = MyEncrypter.GetInstance();
//var file = Directory.GetFiles("encrypt");
//foreach (var f in file)
//{
//    Console.WriteLine(f + "\n");
//    string fileContent = File.ReadAllText(f);
//    string encryptLine = encrypter.Encrypt(fileContent, 2);
//    File.WriteAllText(f, encryptLine);
//}
//foreach (var f in file)
//{
//    string fileContent = File.ReadAllText(f);
//    string decryptLine = encrypter.Decrypt(fileContent, 2);
//    File.WriteAllText(f, decryptLine);
//}

var encrypter = MyEncrypter.GetInstance();
string smallString = "Hello";
string simularWords = "aaaaaaaaaaaaaaaaaaaaaaa";
string str = "Hello world my name is Antonio Montana";
string longString = "“You always own the option of having no opinion. There is " +
    "never any need to get worked up or to trouble your soul about things you can't control. " +
    "These things are not asking to be judged by you. Leave them alone.” \n“Remember that man lives only in the present," +
    " in this fleeting instant; all the rest of his life is either past and gone, or not yet revealed.” \n" +
    " By using the basics, you should be like a pugilist, not a gladiator. After all, as soon as the last one loses the" +
    " sword with which he fights then, it will be the end for him, as the first hands are always with him, and he only needs to clench them into fists.";
string encryptLine = encrypter.Encrypt(longString, "password");
string decryptLine = encrypter.Decrypt(encryptLine, "password");
Console.WriteLine("Line:");
Console.WriteLine(longString + "\n");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Encrypt line:");
Console.WriteLine(encryptLine + "\n");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Decrypt line:");
Console.WriteLine(decryptLine);



















