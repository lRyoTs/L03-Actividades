using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public int num1 = 10;
    public int num2 = 2;
    // Start is called before the first frame update
    void Start()
    {
        doDivision(num1,num2);
    }

    //Check if the division is exact
    private void doDivision(int dividend, int divisor) {
        int result = dividend / divisor;
        if (dividend % divisor == 0)
        {
            Debug.Log($"The division is exact");
        }
        else {
            Debug.Log($"The division is NOT exact");
        }
    }
}
