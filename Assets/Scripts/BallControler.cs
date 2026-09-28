using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallControler : MonoBehaviour{


    // Atributes :
    public Rigidbody2D rigidboryBall;
    public AudioClip audioCollider;
    private float boundaryHorizontal;
    private float direction;
    private float speed;
    private Vector2 speedBall;


    // Function that runs once when the game starts :
    void Start()    
    {


        // Defining the initial position of the ball and the speed ball :
        transform.position = new Vector3(0, 0, 0);
        speed = 5f;


        // Definindo the horizontal boundary :
        boundaryHorizontal = 10f;


        // Defining the random direction of the ball :
        direction = Random.Range(0, 4);


        // If the direction is equal to 0 :
        if (direction == 0)
        {


            speedBall.y = speed;
            speedBall.x = -speed;


        }


        // If the direction is equal to 1 :
        else if (direction == 1)
        {


            speedBall.y = -speed;
            speedBall.x = -speed;


        }


        // If the direction is equal to 2 :
        else if (direction == 2)
        {


            speedBall.y = speed;
            speedBall.x = speed;


        }


        // If the derection is equal to 3
        else if (direction == 3)
        {
        
        
            speedBall.y = -speed;
            speedBall.x = speed;


        }


        // Defining the initial speed of the ball :
        rigidboryBall.linearVelocity = speedBall;


    }


    // Function that runs every frame :
    void Update()
    {


        // Defining action when the ball out of the horizontal boundary and reseting the scene :
        if (transform.position.x > boundaryHorizontal)
        {


            Debug.Log("Raquete da esquedar venceu!");
            SceneManager.LoadScene(0);


        }


        // Defining action when the ball out of the horizontal boundary and reseting the scene :
        if (transform.position.x < -boundaryHorizontal)
        {


            Debug.Log("Raquete da direita venceu!");
            SceneManager.LoadScene(0);


        }
    
    
    }


    // Action when the ball collides with the racket or the wall :
    private void OnCollisionEnter2D(Collision2D collision)
    {


        AudioSource.PlayClipAtPoint(audioCollider, transform.position);

        
    }


}
