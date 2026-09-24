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


        movimentsPositions.y = verticalPosition;
        transform.position = movimentsPositions;


        if (Input.GetKey(KeyCode.UpArrow)){


            verticalPosition = verticalPosition + 0.5f;


        }


        else if (Input.GetKey(KeyCode.DownArrow)){
        
        
            verticalPosition = verticalPosition - 0.5f;
        
        
        }


        Debug.Log(transform.position.y);

        
    }


}