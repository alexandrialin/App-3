using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantWatered : MonoBehaviour
{
    public float cooldown = 0;
    public float lag = 0;
    public CharacterSwitch cs;
    Transform playerTransform;
    public GameObject player;
    public float distance;

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
        distance = Vector3.Distance(playerTransform.position, transform.position);
        if (Input.GetMouseButton(0) && lag <= 0f)
        {
            Watered(cs.targetName, 1);
            lag = 0.5f;
        }
        if (Input.GetMouseButton(1) && HumanP1.ultActive == true)
        {
            Watered(cs.targetName, 2);
        }
        if (lag > 0)
        {
            lag -= Time.deltaTime;
        }

    }

    public void Watered(string mcType, int skill)
    {
        if (Mathf.Abs(distance) < 5 && skill == 1)
        {
            if (mcType == "teal")
            {
                EarthProgression.plantWatered = true;
                gameObject.SetActive(false);
            }

        }
        if (Mathf.Abs(distance) < 8 && skill == 2)
        {
            if (mcType == "teal")
            {
                EarthProgression.plantWatered = true;
                gameObject.SetActive(false);
            }

        }
    }
}
