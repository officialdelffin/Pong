using UnityEngine;

public class RacketControler : MonoBehaviour{


    // Attributes :
    private Vector3 movimentsPositions;
    private float verticalPosition;  


    // Function that runs once when the game starts :
    void Start(){


        // Defining the default position of the x and z axes :
        movimentsPositions.x = -7.5f;
        movimentsPositions.z = 0f;


    }

    // Function that runs every frame :
    void Update(){


        movimentsPositions.y = verticalPosition;
        transform.position = movimentsPositions;


        Debug.Log(transform.position.y);

        
    }


}