using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    
    float speedY = 20f, speedX = 10f, minLimitY = -3.98f, maxLimitY = 3.98f,
       minLimitX = 0, maxLimitX = 10.45f;
    Vector3 deltaPos = new Vector3(9.16f,-0.01f);
    public Material blue,red, green;
    int currentScore = 0;
    public TextMesh scoreTXT;
    int currentlife = 8;
    public TextMesh lifeTXT;
    new Renderer renderer;
    GeneralController generalController;

    private void Start()
    {
        scoreTXT.text = currentScore.ToString();
        lifeTXT.text = currentlife.ToString();
        renderer = GetComponent<Renderer>();
        renderer.material = selectColor();
    }

    private void Awake()
    {
        generalController = GameObject.Find("GeneralController").GetComponent<GeneralController>();
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

        if (other.CompareTag("Square"))
        {
            renderer.material = other.GetComponent<Renderer>().material;
        }
        else if (other.CompareTag("Life"))
        {
            incrementLife();
        }
        else if (other.CompareTag("Speed"))
        {
            generalController.incrementSpeed = true;
        }
        else
        {
            if (other.GetComponent<Renderer>().material.color.Equals(renderer.material.color))
            {
                incrementScore();
            }
            else
            {
                decreaseLife();
            }
        }

        Destroy(other.gameObject);
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

    public void incrementLife()
    {
        currentlife++;
        lifeTXT.text = currentlife.ToString();
    }

    public void decreaseLife()
    {
        currentlife--;
        lifeTXT.text = currentlife.ToString();
    }

}
