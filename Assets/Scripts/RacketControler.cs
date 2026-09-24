using UnityEngine;

public class RacketControler : MonoBehaviour{


    // Attributes :
    private Vector3 movimentsPositions;
    private float verticalPosition;
    private float speed;
    private float boundary;



    // Function that runs once when the game starts :
    void Start(){


        // Defining the default position of the x and z axes :
        movimentsPositions.x = transform.position.x;
        movimentsPositions.z = transform.position.z;


        // Defining the speed of the racket :
        speed = 5f;


        // Defining the boundary of the racket :
        boundary = 3.5f;


    }

    // Function that runs every frame :
    void Update(){


        // Defining that the y axis will be equal to the vertical position :
        movimentsPositions.y = verticalPosition;
        transform.position = movimentsPositions;


        // Defining the movement of the racket :
        if (verticalPosition < boundary){

            
            if (Input.GetKey(KeyCode.UpArrow))
            {


                verticalPosition = verticalPosition + speed * Time.deltaTime;


            }


        }


        // Defining the movement of the racket :
        if (verticalPosition > -boundary){

            
            if (Input.GetKey(KeyCode.DownArrow)) {


                verticalPosition = verticalPosition - speed * Time.deltaTime;


            }


        }

        
    }


}