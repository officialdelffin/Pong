using UnityEngine;


public class TestScript : MonoBehaviour {


    // Function called when the script is first run :
    void Start() {


        Debug.Log("A camera foi ligada!");
    

    }


    // Function called once per frame :
    void Update() {


        Debug.Log("Teste");
        Debug.Log("A camera está gravando!");
        Debug.LogWarning("A camera está descarregando!");
        Debug.LogError("A camera descarregou!");


    }


}
