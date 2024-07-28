using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    //declaring a variable to select the rotation tartget
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //Rotate around the first parameter target position 
      //rotate arou nd secound parameter about the axis or rotation
      //rotate around third parameter needed is the speed of rortation.
      transform.RotateAround(target.transform.position, target.transform.up, speed  * Time.deltaTime);   
    }
}
