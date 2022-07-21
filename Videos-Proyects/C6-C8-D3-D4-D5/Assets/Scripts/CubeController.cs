using UnityEngine;

public class CubeController : MonoBehaviour
{
    float startingForce = 500f;
    bool hasStarted = false;
    new Rigidbody rigidbody;
    Vector3 startingForceVector = new Vector3(1,1);

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!hasStarted && Input.GetButtonDown("Fire1"))
        {
            hasStarted = true;
            startingForceVector *= startingForce;
            rigidbody.AddForce(startingForceVector);
        }
    }
}
