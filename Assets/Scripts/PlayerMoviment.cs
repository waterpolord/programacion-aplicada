using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    
    float speedY = 20f, speedX = 10f, minLimitY = -3.98f, maxLimitY = 3.98f,
       minLimitX = 0, maxLimitX = 10.45f;
    Vector3 deltaPos = new Vector3(9.16f,-0.01f);
    public Material blue,red, green;
    int currentScore = 0;
    public TextMesh scoreTXT;
    Renderer renderer;

    private void Start()
    {
        scoreTXT.text = currentScore.ToString();
        renderer = GetComponent<Renderer>();
        renderer.material = selectColor();
    }
    void Update()
    {
        

        deltaPos.y = Input.GetAxis("Vertical") * speedY * Time.deltaTime;
        deltaPos.x = Input.GetAxis("Horizontal") * speedX * Time.deltaTime;

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
                Mathf.Clamp( gameObject.transform.position.x,minLimitX,maxLimitX),
                Mathf.Clamp( gameObject.transform.position.y,minLimitY,maxLimitY),
                gameObject.transform.position.z
            );
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        if (other.GetComponent<Renderer>().material.color.Equals(renderer.material.color) ) {
            incrementScore();
        }
        else
        {
            decreaseScore();
        }
    }

    private Material selectColor()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                return red;
            case 1:
                return blue;
            default:
                return green;
        }
    }

    public void incrementScore()
    {
        currentScore++;
        scoreTXT.text = currentScore.ToString();
    }

    public void decreaseScore()
    {
        currentScore--;
        scoreTXT.text = currentScore.ToString();
    }

}
