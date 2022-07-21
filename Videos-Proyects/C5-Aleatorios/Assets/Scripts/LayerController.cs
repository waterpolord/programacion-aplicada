using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{
    // Start is called before the first frame update

    float scrollingSpeed = 0.2f;
    Vector2 currentPos = new Vector2();
    MeshRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        currentPos.x = currentPos.x + scrollingSpeed * Time.deltaTime;
        //currentPos.y = currentPos.y + scrollingSpeed * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPos;        
    }
}
