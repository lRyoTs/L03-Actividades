using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        increaseScale();
    }

    // Update is called once per frame
    void Update()
    {
        //Check is mouse left-click pressed
        if (Input.GetMouseButtonDown(0)) {
            increaseScale();
        }
    }

    //Increase scale in each axis everytime is called
    private void increaseScale() {
        transform.localScale += Vector3.one; //Increase scale in each axis
        Debug.Log("The scale had been increased");
    }
}
