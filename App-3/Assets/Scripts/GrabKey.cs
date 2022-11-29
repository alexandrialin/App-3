using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabKey : MonoBehaviour
{
    public GameObject player;
    public GameObject green;
    public GameObject teal;
    public GameObject orange;
    public GameObject blue;
    public float distance;
    public GameObject popup;
    public GameObject getKey;
    public float getKeyTimer;
    Transform playerTransform;
    public CharacterSwitch cs;

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
        if (Mathf.Abs(distance) < 4)
        {
            popup.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
                if (gameObject.CompareTag("key"))
                {
                    GameProgression.hasKey = true;
                    gameObject.SetActive(false);
                }
                if (gameObject.CompareTag("chest"))
                {
                    if (GameProgression.hasKey && GameProgression.iceMelt)
                    {
                        GameProgression.hasChest = true;
                    }
                    else if (GameProgression.iceMelt)
                    {
                        getKey.SetActive(true);
                        getKeyTimer = 2f;
                    }

                }


            }
        }
        else
        {
            popup.SetActive(false);
        }

        if (getKeyTimer >= 0)
        {
            getKeyTimer -= Time.deltaTime;

        }
        else
        {
            getKey.SetActive(false);
        }

        if (cs.targetName == "green")
        {
            player = green;
            GetPlayerTransform();
        }
        if (cs.targetName == "blue")
        {
            player = blue;
            GetPlayerTransform();
        }
        if (cs.targetName == "orange")
        {
            player = orange;
            GetPlayerTransform();
        }
        if (cs.targetName == "teal")
        {
            player = teal;
            GetPlayerTransform();
        }

    }
}
