using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex06 : MonoBehaviour
{
    public int num1 = 1;
    public int num2 = 2;

    // Start is called before the first frame update
    void Start()
    {
        //Choose which number is greater to display
        Debug.Log($"The greater number is {chooseGreater(num1,num2)}");


    }

    private int chooseGreater(int num1, int num2) {
        if (num1 > num2)
        {
            return num1;
        }
        else if (num2 > num1)
        {
            return num2;
        }
        else
        {
            return num1;
        }
    }
}
