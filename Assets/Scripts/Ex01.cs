using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    public string letter = "a"; //Variable that store a letter

    // Start is called before the first frame update
    void Start()
    {
        //Choose if the letter is a vowel or consonant
        if (isVowel(letter)) { 
            Debug.Log($"The letter {letter} is a vowel");
        }
        else {
            Debug.Log($"The letter {letter} is a consonant");
        }
    }
    
    //FUnction that check if a letter is a vowel return a bool value
    private bool isVowel(string letter) {
        if (((letter == "a") || (letter == "A")) || ((letter == "e") || (letter == "E")) || ((letter == "i") || (letter == "I")) || ((letter == "o") || (letter == "O")) || ((letter == "u") || (letter == "U")))
        {
           return true;
        }
        else
        {
            return false;
        }
    }
}
