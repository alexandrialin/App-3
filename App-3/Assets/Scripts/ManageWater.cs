using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageWater : MonoBehaviour
{
    public float cooldown = 0;
    public float lag = 0;
    public CharacterSwitch cs;
    Transform playerTransform;
    public GameObject player;
    public GameObject blue;
    public float distance;
    public GameObject ice;

    // Start is called before the first frame update
    void GetPlayerTransform()
    {
        if (player != null)
        {
            playerTransform = player.transform;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GetPlayerTransform();
    }

    // Update is called once per frame
    void Update()
    {
        distance = playerTransform.position.z - transform.position.z;

        if (Input.GetMouseButton(1) && HumanP1.ultActive == true)
        {
            WaterFrozen(cs.targetName);
        }

    }

    public void WaterFrozen(string mcType)
    {
        if (Mathf.Abs(distance) < 12)
        {
            if (mcType == "blue")
            {
                ice.SetActive(true);
                gameObject.SetActive(false);
            }

        }
    }
}
