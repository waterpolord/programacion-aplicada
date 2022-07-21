using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralController : MonoBehaviour
{
    public Vector2 objectSpeed = new Vector2(15, 0);
    public bool incrementSpeed = false;
    public float speedIncrementValue = 5.0f,waitTime = 5.0f,timer = 0.0f, naturalSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (incrementSpeed)
        {

            timer += Time.deltaTime;
            objectSpeed.x += speedIncrementValue * Time.deltaTime;
            if (timer > waitTime)
            {
                timer = 0.0f;
                incrementSpeed = false;
                objectSpeed.x = naturalSpeed;
            }


        }

    }
}
