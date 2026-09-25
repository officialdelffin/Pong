using UnityEngine;


public class BallControler : MonoBehaviour{


    // Atributes :
    public Rigidbody2D rigidboryBall;
    public Vector2 speedBall;


    // Function that runs once when the game starts :
    void Start(){


        // Defining the initial position of the ball :
        transform.position = new Vector3(0, 0, 0);


        // Defining the initial speed of the ball :
        rigidboryBall.linearVelocity = speedBall;


    }


    // Function that runs every frame :
    void Update(){




        
    }


}
