using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLight : MonoBehaviour
{
    public float cooldown = 0;
    public float lag = 0;
    public CharacterSwitch cs;
    Transform playerTransform;
    public GameObject player;
    public GameObject orange;
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
            TorchLit(cs.targetName);
            lag = 0.5f;
        }
        if (Input.GetMouseButton(1) && HumanP1.ultActive == true)
        {
            TorchLit(cs.targetName);
        }
        if (lag > 0)
        {
            lag -= Time.deltaTime;
        }

    }

    public void TorchLit(string mcType)
    {
        if (Mathf.Abs(distance) < 4)
        {
            if (mcType == "orange")
            {
                GameProgression.numTorches++;
                gameObject.SetActive(false);
            }

        }
    }

}
