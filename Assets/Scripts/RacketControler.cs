using Unity.VisualScripting;
using UnityEngine;

public class RacketControler : MonoBehaviour{


    // Attributes :
    public bool leftRacketPlayer;
    public bool rightRacketPlayer;
    public bool rightRacketAuto;
    public Transform ballPosition;
    private Vector3 movimentsPositions;
    private float verticalPosition;
    private float speed;
    private float boundary;


    // Function that runs once when the game starts :
    void Start()
    {


        // Defining the default position of the x and z axes :
        movimentsPositions.x = transform.position.x;
        movimentsPositions.z = transform.position.z;


        // Defining the speed of the racket :
        speed = 5f;


        // Defining the boundary of the racket :
        boundary = 3.5f;


    }


    // Function that runs every frame :
    void Update()
    {


        // Defining that the y axis will be equal to the vertical position :
        movimentsPositions.y = verticalPosition;
        transform.position = movimentsPositions;


        // Defining the racket that will be used :
        if (leftRacketPlayer)
        {


            // Defining the movement of the racket :
            if (verticalPosition < boundary)
            {


                if (Input.GetKey(KeyCode.W))
                {


                    verticalPosition = verticalPosition + speed * Time.deltaTime;


                }


            }


            // Defining the movement of the racket :
            if (verticalPosition > -boundary)
            {


                if (Input.GetKey(KeyCode.S))
                {


                    verticalPosition = verticalPosition - speed * Time.deltaTime;


                }


            }


        }


        // Defining the racket that will be used :
        else if (rightRacketPlayer)
        {

            // Defining the movement of the racket :
            if (verticalPosition < boundary)
            {


                if (Input.GetKey(KeyCode.UpArrow))
                {


                    verticalPosition = verticalPosition + speed * Time.deltaTime;


                }


            }


            // Defining the movement of the racket :
            if (verticalPosition > -boundary)
            {


                if (Input.GetKey(KeyCode.DownArrow))
                {


                    verticalPosition = verticalPosition - speed * Time.deltaTime;


                }


            }


        }


        // Defining the racket that will be used and is automated for computer :
        else if (rightRacketAuto)
        { 
        
        
            // Getting the posittion y of the ball :
            float ballPositionY = ballPosition.position.y;


            // Defining the movement of the racket based on the ball's position y :
            transform.position = new Vector3(transform.position.x, ballPositionY, transform.position.z);


        }


        // Definig the limit of the racket's movement :
        if (verticalPosition > boundary)
        {


            verticalPosition = boundary;


        }


        // Definig the limit of the racket's movement :
        else if (verticalPosition < -boundary)
        {


            verticalPosition = -boundary;


        }


    }


}