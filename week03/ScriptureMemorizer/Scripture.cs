using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Word;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using Reference;


public class Scripture
{
    
        //static string sentisaizedWord = sentisaized.GetWord();
    string wordx = WordGenerator.GetRandomWord().Item1; 
    int indexx = WordGenerator.GetRandomWord().Item2;
    
    string fullscripture = WordGenerator.GetFullScripture().Item1;
    int wordLen = WordGenerator.GetFullScripture().Item2;
    int indexsentisized = WordGenerator.sentisaizedIndex;
    string trakedreferance;

    public Scripture()
    {
        trakedreferance = DesplayReferance();
    }

    public string DesplayReferance()
    {
        trakedreferance = ReferenceTracker.ReferncePicker(indexsentisized);
        return trakedreferance;
    }

    public (string, int) PrintMessage()
    {
       // Console.WriteLine(wordx);
        //Console.WriteLine(indexx);
        return (fullscripture, wordLen);
    }

    public string DisplayHiden()
    {
        string hidenWord = WordGenerator.WordHider();
        
        return hidenWord;
    }
    public (string, int) DisplayFull()
    {
        return (fullscripture,wordLen);
    }
}


