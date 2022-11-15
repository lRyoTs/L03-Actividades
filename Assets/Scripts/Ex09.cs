using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex09 : MonoBehaviour
{
    public float bases;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        getTriangleArea(bases, height);
    }

    //Function that gets the area of the triangle return a float value
    float getTriangleArea(float bases, float height) {
        float result; //Store result form the operation
        if (bases <= 0 || height <= 0) { //check if the number area positive
            Debug.Log($"The area cannot be calculated");
            return -1;
        }
     
        //Get area of the triangle
        result = (bases * height) / 2; //Triangle's area == (b*h)/2
        //Display
        Debug.Log($"The area of the triangle with base={bases} and height={height} is {result}");
        
        return result;
    }
}
