using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    float _speedY = 20f, _speedX = 10f;
    Vector3 _deltaPos = new Vector3();
    const float min_limit_Y = -4.25f, max_limit_Y = 4.25f,
        min_limit_X = -2.18f, max_limit_X = 2.18f;
    void Update()
    {
        _deltaPos.y = Input.GetAxis("Vertical") * _speedY * Time.deltaTime;
        _deltaPos.x = Input.GetAxis("Horizontal") * _speedX * Time.deltaTime;
        //_deltaPos.z = Input.GetAxis("Horizontal") * _speedX * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3
        (
           Mathf.Clamp( gameObject.transform.position.x,min_limit_X,max_limit_X),
           Mathf.Clamp( gameObject.transform.position.y,min_limit_Y,max_limit_Y),
            gameObject.transform.position.z
            );
    }
}
