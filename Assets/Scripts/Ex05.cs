using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex05 : MonoBehaviour
{
    public int number = 2; 

    // Start is called before the first frame update
    void Start()
    {
        multTable(number); //Make multiplication table

    }

    //Function that gets the multiplication table of the provided number
    private void multTable(int number) {
        string message = ""; //Stores the message to display
        //Get multiplication table of the selected number
        for (int i = 1; i <= 10; i++)
        {
            message += $"{number} x {i} = {number * i}\n";
        }
        //Display multiplication table message
        Debug.Log(message);
    }
}
