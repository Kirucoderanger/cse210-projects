using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Word;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;

public class Scripture
{
    string wordx = WordGenerator.GetRandomWord().Item1; 
    int indexx = WordGenerator.GetRandomWord().Item2;

    public (string, int) PrintMessage()
    {
       // Console.WriteLine(wordx);
        //Console.WriteLine(indexx);
        return (wordx, indexx);
    }
}


