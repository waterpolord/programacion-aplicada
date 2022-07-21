using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoviment : MonoBehaviour
{
    // Start is called before the first frame update

    float scrollingSpeed = 0.2f;
    Vector2 currentPos = new Vector2();
    Vector2 speed = new Vector2(15, 0);




    // Update is called once per frame
    void Update()
    {
        currentPos.x = speed.x * Time.deltaTime;
        //currentPos.y = currentPos.y + scrollingSpeed * Time.deltaTime;
        gameObject.transform.Translate(currentPos);
        //renderer.material.mainTextureOffset = currentPos;
    }
}
