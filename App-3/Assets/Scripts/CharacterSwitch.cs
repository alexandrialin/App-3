using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public GameObject target;
    public string targetName;
    public int attackDistance;
    public int ultDistance;
    public GameObject green;

    public GameObject blue;

    public GameObject orange;

    public GameObject teal;

    public Vector3 coordinates1;

    public GameObject pauseMenu;
    public bool paused = false;

    public CamController cc;


    Vector3 offset;

    void Start()
    {


        target = orange;
 
        offset = transform.position - target.transform.position;
        targetName = "orange";
        attackDistance = 15;
        ultDistance = 10;
    }
    void Update()
    {
        coordinates1 = target.transform.position;

        if (Input.GetKey(KeyCode.Escape))
        {

            pauseMenu.SetActive(true);

        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            green.transform.position = coordinates1;
            attackDistance = 4;
            ultDistance = 10;
            target = green;
            targetName = "green";
            
            green.SetActive(true);

            teal.SetActive(false);

            orange.SetActive(false);
    
            blue.SetActive(false);

            cc.SetPlayer(green);

      
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            teal.transform.position = coordinates1;

            target = teal;
            targetName = "teal";
            attackDistance = 15;
            ultDistance = 10;
            green.SetActive(false);
        
            teal.SetActive(true);
           
            orange.SetActive(false);
     
            blue.SetActive(false);
            cc.SetPlayer(teal);

        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            orange.transform.position = coordinates1;
         
            target = orange;
            targetName = "orange";
            attackDistance = 15;
            ultDistance = 10;

            green.SetActive(false);
   
            teal.SetActive(false);
   
            orange.SetActive(true);

            blue.SetActive(false);
            cc.SetPlayer(orange);

        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            blue.transform.position = coordinates1;
 
            target = blue;
            targetName = "blue";
            attackDistance = 4;
            ultDistance = 10;
            green.SetActive(false);
 
            teal.SetActive(false);
   
            orange.SetActive(false);

            blue.SetActive(true);
            cc.SetPlayer(blue);

        }
    }

    void LateUpdate()
    {

        Vector3 desiredPosition = target.transform.position + offset;
        transform.position = desiredPosition;

    }
}
