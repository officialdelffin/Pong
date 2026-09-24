using UnityEngine;

public class RacketControler : MonoBehaviour{


    // Attributes :
    private Vector3 movimentsPositions;
    private float verticalPosition;  


    // Function that runs once when the game starts :
    void Start(){


        // Defining the default position of the x and z axes :
        movimentsPositions.x = transform.position.x;
        movimentsPositions.z = transform.position.z;


    }

    // Function that runs every frame :
    void Update(){


        // Defining that the y axis will be equal to the vertical position :
        movimentsPositions.y = verticalPosition;
        transform.position = movimentsPositions;


        // Defining the movement of the racket :
        if (Input.GetKey(KeyCode.UpArrow)){


            verticalPosition = verticalPosition + 5f * Time.deltaTime;


        }


        // Defining the movement of the racket :
        else if (Input.GetKey(KeyCode.DownArrow)){
        
        
            verticalPosition = verticalPosition - 5f * Time.deltaTime;
        
        
        }

        
    }


}