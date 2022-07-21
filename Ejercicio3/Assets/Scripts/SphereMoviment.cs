
using UnityEngine;

public class SphereMoviment : MonoBehaviour
{
    // Start is called before the first frame update

    
    Vector2 currentPos = new Vector2();
    public bool incrementSpeed = false;
    GeneralController generalController;

    private void Awake()
    {
        generalController = GameObject.Find("GeneralController").GetComponent<GeneralController>();
    }
    // Update is called once per frame
    void Update()
    {

        currentPos.x = generalController.objectSpeed.x * Time.deltaTime;
       
        
        //currentPos.y = currentPos.y + scrollingSpeed * Time.deltaTime;
        gameObject.transform.Translate(currentPos);
        //renderer.material.mainTextureOffset = currentPos;
    }

    public void setSpeed()
    {
        incrementSpeed = true;
    }

    
}
