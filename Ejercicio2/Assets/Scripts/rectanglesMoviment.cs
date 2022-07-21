using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectanglesMoviment : MonoBehaviour
{
    Vector3 currPos = new Vector3(0,3.52f);
    const float maxX = 6f,speedY = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currPos.x = -20.99f + Mathf.PingPong(Time.time * speedY, maxX);
        gameObject.transform.position = currPos;
    }

    
}
