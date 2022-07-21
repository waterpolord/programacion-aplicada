using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    private Animator animator;
    Vector3 deltaPos = new Vector3(0, 0);
    float speedRun = 10f,speedWalking = 5f, currSpeedX,currSpeedY,
        minLimitY = 0.49f, maxLimitY = 35.19f,
       minLimitX = 0.21f, maxLimitX = 100f;
    SpriteRenderer sprite;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("Atacking", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("Atacking", false);
        }
        if(Mathf.Abs( Input.GetAxis("Horizontal")) > 0)
        {
            currSpeedX = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? speedRun : speedWalking) * Time.deltaTime;
            deltaPos.x = currSpeedX;
            animator.SetFloat("Speed", Mathf.Abs(currSpeedX));
            gameObject.transform.Translate(deltaPos);

        }
        else if( Mathf.Abs(Input.GetAxis("Vertical")) > 0)
        {
            currSpeedY = Input.GetAxis("Vertical") * (Input.GetButton("Fire3") ? speedRun : speedWalking) * Time.deltaTime;
            deltaPos.y = currSpeedY;
            animator.SetFloat("Speed", Mathf.Abs(currSpeedY));
            gameObject.transform.Translate(deltaPos);
        }
        gameObject.transform.position = new Vector3(
                Mathf.Clamp(gameObject.transform.position.x, minLimitX, maxLimitX),
                Mathf.Clamp(gameObject.transform.position.y, minLimitY, maxLimitY),
                gameObject.transform.position.z
            );

        sprite.flipX = currSpeedX < 0;
        

    }
}
