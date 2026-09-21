using UnityEngine;


public class TestScript : MonoBehaviour {


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {


        Debug.Log("A camera foi ligada!");
    

    }


    // Update is called once per frame
    void Update() {


        Debug.Log("A camera está gravando!");
        Debug.LogWarning("A camera está descarregando!");
        Debug.LogError("A camera descarregou!");


    }


}
