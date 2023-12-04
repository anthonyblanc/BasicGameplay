using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float tooBound = 30;
    private float lowerbound = 2.50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > tooBound) 
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }
    }
    
}
