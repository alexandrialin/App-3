using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CamController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //set offset
        offset = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //set so camera can follow player
        transform.position = player.transform.position + offset;
        
    }

    public void SetPlayer(GameObject player)
    {
        this.player = player;
    }
}
