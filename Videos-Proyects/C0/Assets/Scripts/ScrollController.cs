using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
    private MeshRenderer renderer;
    const float scrollingSpeedX = 0.5f;
    Vector2 currentPos = Vector2.zero;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentPos.x += scrollingSpeedX * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPos;
        
        
    }
}
