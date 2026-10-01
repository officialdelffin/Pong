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
    private float boundaryVertical;


    // Function that runs once when the game starts :
    void Start()
    {


        // Defining the default position of the x and z axes :
        movimentsPositions.x = transform.position.x;
        movimentsPositions.z = transform.position.z;


        // Defining the speed of the racket :
        speed = 5f;


        // Defining the boundary of the wall :
        boundaryVertical = 3.5f;


        // Defining that the default right racket is automated for computer :
        rightRacketAuto = true;
        rightRacketPlayer = false;


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
            if (verticalPosition < boundaryVertical)
            {


                if (Input.GetKey(KeyCode.W))
                {


                    verticalPosition = verticalPosition + speed * Time.deltaTime;


                }


            }


            // Defining the movement of the racket :
            if (verticalPosition > -boundaryVertical)
            {


                if (Input.GetKey(KeyCode.S))
                {


                    verticalPosition = verticalPosition - speed * Time.deltaTime;


                }


            }


        }


        // Defining the racket that will be used and is automated for computer :
        else if (rightRacketAuto)
        {


            // Defining and limiting the movement of the racket :
            verticalPosition = Mathf.Lerp(verticalPosition, ballPosition.transform.position.y, 0.06f);


            // If the space key is pressed, the right racket will be controlled by the player :
            if (Input.GetKeyDown(KeyCode.Space))
            {


                rightRacketAuto = false;
                rightRacketPlayer = true;


            }


        }


        // Defining the racket that will be used :
        else if (rightRacketPlayer)
        {

            // Defining the movement of the racket :
            if (verticalPosition < boundaryVertical)
            {


                if (Input.GetKey(KeyCode.UpArrow))
                {


                    verticalPosition = verticalPosition + speed * Time.deltaTime;


                }


            }


            // Defining the movement of the racket :
            if (verticalPosition > -boundaryVertical)
            {


                if (Input.GetKey(KeyCode.DownArrow))
                {


                    verticalPosition = verticalPosition - speed * Time.deltaTime;


                }


            }


            // If the space key is pressed, the right racket will be automated for computer :
            if (Input.GetKeyDown(KeyCode.Space))
            {


                rightRacketAuto = true;
                rightRacketPlayer = false;


            }


        }


        // Definig the limit of the racket's movement :
        if (verticalPosition > boundaryVertical)
        {


            verticalPosition = boundaryVertical;


        }


        // Definig the limit of the racket's movement :
        else if (verticalPosition < -boundaryVertical)
        {


            verticalPosition = -boundaryVertical;


        }


    }


}