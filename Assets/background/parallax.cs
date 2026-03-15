using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public GameObject cam; 
    private float length, startPos; 
    public float parllaxEf; 

    void Start()
    {
    startPos = transform.position.x; 
    length = GetComponent<SpriteRenderer>().bounds.size.x;
 

        
    }

 
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parllaxEf));
        float distance =  (cam.transform.position.x * parllaxEf);
        
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
       
        if (temp > startPos + length) startPos += length; 
        else if ( temp < startPos - length) startPos -= length; 
    }
}
