using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    int speedAmt = 5;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if(transform.position.x<=1.9)
        {
            speedAmt = 5;
        }
        if(transform.position.x>=14.2)
        {
            speedAmt = -5;
        }
        transform.Translate(speedAmt * Time.deltaTime, 0, 0);
        
    }

}
