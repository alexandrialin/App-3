using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    Transform playerTransform;
    public CharacterSwitch cs;
    public GameObject player;
    public GameObject green;
    public GameObject teal;
    public GameObject orange;
    public GameObject blue;
    public float distance;
    public GameObject popup;

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
        if (Mathf.Abs(distance) < 7)
        {
            popup.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
                if(gameObject.CompareTag("fire"))
                {
                    SceneManager.LoadScene("FireLevel");
                }
                if (gameObject.CompareTag("earth"))
                {
                    SceneManager.LoadScene("EarthLevel");
                }
                if (gameObject.CompareTag("ice"))
                {
                    SceneManager.LoadScene("IceLevel");
                }
                if (gameObject.CompareTag("water"))
                {
                    SceneManager.LoadScene("WaterLevel");
                }
            }
        }
        else
        {
            popup.SetActive(false);
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
