using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] itemPrefab;

    public float minTime = 1f;
    public float maxTime = 2f;

    public GameObject objeto;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoRoutine(0));   
    }

    IEnumerator SpawnCoRoutine(float waitTime){
        yield return new WaitForSeconds(waitTime);
        objeto = itemPrefab[Random.Range(0, itemPrefab.Length)];
        var newObject = (GameObject) Instantiate(objeto, new Vector3(Random.Range(-5, 66.8f),Random.Range(20, 30),Random.Range(-40, 210)), Quaternion.identity);
        StartCoroutine(SpawnCoRoutine(Random.Range(minTime, maxTime)));
        //StartCoroutine(DeleteCoRoutine(5));
    }

    /*IEnumerator DeleteCoRoutine(float waitTime){
        yield return new WaitForSeconds(waitTime);
        if(gameObject.name == "SM_Rock_Boulder_01(Clone)"|| gameObject.name == "Prop_Barrier02(Clone)"){
            Destroy(gameObject);
        }
    }*/
    
}
