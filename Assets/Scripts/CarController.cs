using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{      
    //private bool estaAcelerando = false;
    //private float aceleracion = 0f;
    private float velocidad = 20;
    public CameraMove myCameraMove;
    private bool isGoingForward = false;
    private bool isGoingBack = false;

    
    // Start is called before the first frame update
    void Start()
    {
        isGoingForward = false;
        isGoingBack = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A) ){
            if(isGoingForward){
                transform.Rotate(new Vector3(0,0.5f*-1,0));
            }else if(isGoingBack){
                transform.Rotate(new Vector3(0,0.5f,0));
            }
            
        }

        if(Input.GetKey(KeyCode.W) ){
            isGoingForward = true;
            isGoingBack = false;
            transform.Translate(Vector3.forward*Time.deltaTime*velocidad);
            
            //acelerar();
        }

        if(Input.GetKey(KeyCode.S) ){
            isGoingBack = true;
            isGoingForward = false;
            transform.Translate(Vector3.back*Time.deltaTime*velocidad);
            
        }

        if(Input.GetKey(KeyCode.D) ){
            if(isGoingForward){
                transform.Rotate(new Vector3(0,0.5f,0));
            }else if(isGoingBack){
                transform.Rotate(new Vector3(0,0.5f*-1,0));
            }          
        }

        if(!Input.GetKey(KeyCode.W) ){
            isGoingForward = false;
            
            //acelerar();
        }

        if(!Input.GetKey(KeyCode.S) ){
            isGoingBack = false;
            
        }

        //isGoingForward = false;
        //isGoingBack = false;
    }

    /*
    void acelerar(){
        if(250f < velocidad){
            

        }
    }*/

}
