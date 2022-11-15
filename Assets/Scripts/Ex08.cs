using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex08 : MonoBehaviour
{
    public int year; //Stores a year

    // Start is called before the first frame update
    void Start()
    {
        if (isLeapYear(year)) {
            Debug.Log("IS LEAP YEAR");
        }
    }

    private bool isLeapYear(int year) {
        if (((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0)) || ((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0)))
        {
            Debug.Log($"{year} is a leap year");
            return true;
        }
        else
        {
            Debug.Log($"{year} is not a leep year");
            return false;
        }
    }
}

