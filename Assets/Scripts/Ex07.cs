using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex07 : MonoBehaviour
{
    public int number = -10; //Stores real number
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"The absolute value of {number} is {getAbsolute(number)}");
    }

    //Function retuns the absolute value of the number
    private int getAbsolute(int number) {
        int result = number;
        if (result < 0) {
            result = result*(-1);
        }
        return result;
    }
}
