using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    private Transform targetPlayer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeleteCoRoutine(10));
    }

    void Update(){
        if(transform.position.y < -2.5f){
             Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    IEnumerator DeleteCoRoutine(float waitTime){
        yield return new WaitForSeconds(waitTime);
        
        if(gameObject.name == "SM_Rock_Boulder_01"|| gameObject.name == "Prop_Barrier02"){
            
        }else{
            Destroy(this.gameObject);
        }


    }
}
