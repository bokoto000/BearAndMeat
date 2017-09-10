using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;   

public class PlayerMovementScript: MonoBehaviour
{
    public Text healthText;
    private int health;
    public Text scoreText;
    private CharacterController controller;
    private float verticalVelocity;
    private float gravity = 100.0f;
    private float jumpForce = 50.0f;
    public float speed = 10.0f;
    public float speedrot = 5.0f;
    private int score;
    private int bearHealth=100;
    public Text Bear;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        score = 0;
        setCount();
        health = 100;
        setHealth();
        bearHealth = 100;
        bearHP();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
        if (controller.isGrounded)
        {
            //Debug.Log(2);
            verticalVelocity = - gravity *Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                //Debug.Log(1);
                verticalVelocity = jumpForce;
            }
            
        }
        else
            {
                //Debug.Log(2);
                verticalVelocity -= gravity*Time.deltaTime;
            }
        
        Vector3 moveVector = Vector3.zero;
        moveVector.x = 0;// ;
        moveVector.y = verticalVelocity;
        moveVector.z = 0; //;
        transform.Rotate(0, Input.GetAxis("Horizontal") *speedrot, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed);

        controller.Move(moveVector*(Time.deltaTime));

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            Destroy(other.gameObject);
            health += 5;
            if (health > 100) health = 100;
            setHealth();
            score++;
            if(score>=25) SceneManager.LoadScene("win");
            setCount();
        }
        if (other.gameObject.CompareTag("Bee"))
        {
            Destroy(other.gameObject);

            health -= 5;
            setHealth();
            if (health <= 0) SceneManager.LoadScene("end");
        }
        if(other.gameObject.CompareTag("Trap"))
        {
            Destroy(other.gameObject);
            health -= 20;
            setHealth();
            if (health <= 0) SceneManager.LoadScene("end");
        }
        if (other.gameObject.CompareTag("Beebox"))
        {
            Destroy(other.gameObject);
            bearHealth -= 20;
            bearHP();
            if(bearHealth==0) SceneManager.LoadScene("win");
        }
    }
    void setCount()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    void setHealth()
    {
        healthText.text = "Health: " + health.ToString();
    }
    void bearHP()
    {
        Bear.text = "Bear Health: " + bearHealth.ToString();
    }
} 