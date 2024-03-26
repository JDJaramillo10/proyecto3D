using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMove : MonoBehaviour
{
    public Transform targetPlayer;
    private Vector3 offset = new Vector3(- 1.57f, +8.63f, -18.36f);
    

    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(targetPlayer.position.x - 1.57f ,targetPlayer.position.y + 8.63f, targetPlayer.position.z-18.36f);        

        
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector3 desiredPosition = targetPlayer.position + targetPlayer.forward * offset.z + targetPlayer.up * offset.y;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 4f);

        transform.LookAt(targetPlayer.position);

    }
}
