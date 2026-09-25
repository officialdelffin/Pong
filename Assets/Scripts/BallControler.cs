using UnityEngine;


public class BallControler : MonoBehaviour{


    // Atributes :
    public Rigidbody2D rigidboryBall;
    public float speed;
    private Vector2 speedBall;


    // Function that runs once when the game starts :
    void Start(){


        // Defining the initial position of the ball :
        transform.position = new Vector3(0, 0, 0);


        // Defining the initial speed and assingning the speedBall variable :
        speed = 5f;
        speedBall.x = -speed;
        speedBall.y = -0.5f;



        // Defining the initial speed of the ball :
        rigidboryBall.linearVelocity = speedBall;


    }


    // Function that runs every frame :
    void Update(){




        
    }


}
