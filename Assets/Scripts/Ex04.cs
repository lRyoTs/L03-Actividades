using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
    public Vector3 otherPosition =  new Vector3 (1, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        translateObject(otherPosition);
    }

    //Function that move the object position
    private void translateObject(Vector3 position) {
        transform.position = position; //Update position
        Debug.Log("Position updated");
    }
}
