string sentence = "Patika eğitimine, Hoşgeldiniz";
string compareSentence= "Eğitime, Hoşgeldiniz.";
//Length;
Console.WriteLine(sentence.Length);

//ToUpper, ToLower
Console.WriteLine(sentence.ToLower());
Console.WriteLine(sentence.ToUpper());

//Concet
Console.WriteLine(String.Concat(sentence, "Hello"));

//Compare, CompareTo
Console.WriteLine(sentence.CompareTo(compareSentence)); // sentence > compareSentence result 1
                                                        // sentence = compareSentence result 0
                                                        // sentence < compareSentence result -1

Console.WriteLine(String.Compare(sentence, compareSentence, true));
Console.WriteLine(String.Compare(sentence, compareSentence, false));

  
//Contains 
Console.WriteLine(sentence.Contains(compareSentence));
Console.WriteLine(sentence.EndsWith("Hoşgeldiniz"));
Console.WriteLine(sentence.StartsWith("Hoşgeldiniz"));

//Indexof
Console.WriteLine(sentence.IndexOf("CSharp"));
Console.WriteLine(sentence.IndexOf("Patika"));


//Insert
Console.WriteLine(sentence.Insert(0, "Merhaba"));

//Padleft, PadRight
Console.WriteLine(sentence + compareSentence.PadLeft(30));
Console.WriteLine(sentence + compareSentence.PadLeft(30, '*'));
Console.WriteLine(sentence.PadRight(50,'-') + compareSentence);

//Remove
Console.WriteLine(sentence.Remove(10));
Console.WriteLine(sentence.Remove(5,3));
Console.WriteLine(sentence.Remove(0,1));

//Replace
Console.WriteLine(sentence.Replace("Patika", "Pati"));
Console.WriteLine(sentence.Replace(" ", "."));

//Split
Console.WriteLine(sentence.Split(" ")[1]);

//Substring
Console.WriteLine(sentence.Substring(4));
Console.WriteLine(sentence.Substring(4,6));