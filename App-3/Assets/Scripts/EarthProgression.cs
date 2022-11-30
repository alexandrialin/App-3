using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthProgression : MonoBehaviour
{
    public GameObject cage;
    public GameObject fairyDialogue;
    public GameObject grownPlant;
    public GameObject smallPlant;
    public GameObject complete;
    public static int birdsKilled;
    public static bool plantWatered;
    public static bool hasPlant;
    public static bool hasOrb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(birdsKilled == 4)
        {
            cage.SetActive(false);
            fairyDialogue.SetActive(true);
        }
        if(plantWatered)
        {
            grownPlant.SetActive(true);
            smallPlant.SetActive(false);
        }
        if(hasOrb)
        {
            complete.SetActive(true);
        }
        if(hasPlant)
        {
            plantWatered = false;
        }
    }
}
