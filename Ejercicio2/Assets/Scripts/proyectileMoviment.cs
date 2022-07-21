using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectileMoviment : MonoBehaviour
{

    Vector2 currentPos = new Vector2();
    float lastTime, deltaTime, initialSpeed = 18f;

    playerScript playerScript;

    void Start()
    {
        lastTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.time - lastTime;

        currentPos.y = initialSpeed * deltaTime + Physics.gravity.y * Mathf.Pow(deltaTime, 2) / 2; 
        //currentPos.y = currentPos.y + scrollingSpeed * Time.deltaTime;
        
        //renderer.material.mainTextureOffset = currentPos;
        initialSpeed += Physics.gravity.y * deltaTime;
        lastTime = Time.time;
        gameObject.transform.Translate(currentPos);
    }

    private void OnTriggerEnter(Collider other)
    {

   
    }



}
