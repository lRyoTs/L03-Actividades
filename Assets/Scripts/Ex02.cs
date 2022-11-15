using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    public int number = 11;
    // Start is called before the first frame update
    void Start()
    {
        if (isEven(number))
        {
            Debug.Log($"The number {number} is even");
        }
        else {
            Debug.Log($"The number {number} is odd");
        }
    }

    //Function that check if a number is even
    private bool isEven(int num) {
        if (num % 2 == 0) { //Check if even else return false
            return true;
        }    
        return false;
    }
}
