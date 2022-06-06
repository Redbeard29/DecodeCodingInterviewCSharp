/* 
Facebook recently conducted a survey on the techniques people use to hide offensive or profane words. The goal was to flag such
words in the posts and messages of users. The most observable pattern was that the characters of a words were repeated multiple
times to avoid detection. A single character in a word was observed to be repeated at least 3 times.This means that characters
repeated less than 3 times will be ignored in the detection process. 

We'll be provided with a string, representing the profane or offensive input word, and another string representing the original
word. We have to determine if the original word can be modified into the manipulated word following the above-mentioned rules.

Ex: initialWord - "moron", manipulatedWord = "mooooronnn"
Output => true
*/

using System;

class FlagWords{
    public static bool flagWords(string initialWord, string manipulatedWord){

        if(initialWord == null || manipulatedWord == null){
            return false;
        }

        int x = 0;
        int y = 0;

        while(x < initialWord.Length && y < manipulatedWord.Length){
            if(initialWord[x] == manipulatedWord[y]){
                int len1 = getLenOfCurrentChar(initialWord, x);
                int len2 = getLenOfCurrentChar(manipulatedWord, y);
                if(len2 < 3 && len1 != len2 || len2 >= 3 && len2 < len1){
                    return false;
                }
                x += len1;
                y += len2;
            }
            else{
                return false;
            }
        }

        return x == initialWord.Length && y == manipulatedWord.Length;
    }

    public static int getLenOfCurrentChar(string currentWord, int idx){
        int start = idx;
        while(idx < currentWord.Length && currentWord[start] == currentWord[idx]){
            idx++;
        }
        return idx - start;
    }

}