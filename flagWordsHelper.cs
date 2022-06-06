class FlagWordsHelper{

    public static void Helper(){
        string initialWord = "moron";
        string manipulatedWord = "mooooronnn";

        if(FlagWords.flagWords(initialWord, manipulatedWord)){
            System.Console.WriteLine("Word Flagged:");
            System.Console.WriteLine("The word " + '"' + manipulatedWord + '"' + " is a potential manipulation of " + '"' + initialWord + '"' + ".");
        }
        else{
            System.Console.WriteLine("Word is safe.");
        }
    }

}