using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Switch()
    {
        OverallHP.hp = OverallHP.full;
        SceneManager.LoadScene("HubWorld");
        if (gameObject.CompareTag("fire"))
        {
            if (GameProgression.fireComplete == false)
            {
                Inventory.money += 100;
                GameProgression.fireComplete = true;
            }
        }
        if (gameObject.CompareTag("water"))
        {
            if (GameProgression.waterComplete == false)
            {
                Inventory.money += 100;
                GameProgression.waterComplete = true;
            }
        }
        if (gameObject.CompareTag("ice"))
        {
            if (GameProgression.iceComplete == false)
            {
                Inventory.money += 100;
                GameProgression.iceComplete = true;
            }
        }
        if (gameObject.CompareTag("earth"))
        {
            if (GameProgression.earthComplete == false)
            {
                Inventory.money += 100;
                GameProgression.earthComplete = true;
            }
        }
  
    }
    public void Death()
    {
        OverallHP.hp = OverallHP.full;
        SceneManager.LoadScene("HubWorld");
        if (gameObject.CompareTag("fire"))
        {
            if (GameProgression.fireComplete == false)
            {
                GameProgression.hasKey = false;
                GameProgression.hasChest = false;
                GameProgression.numTorches = 0;
                GameProgression.fireballs = 0;
                GameProgression.iceMelt = false;
            }
        }
        if (gameObject.CompareTag("water"))
        {

        }
        if (gameObject.CompareTag("ice"))
        {

        }
        if (gameObject.CompareTag("earth"))
        {
            EarthProgression.birdsKilled = 0;
            EarthProgression.plantWatered = false;
            EarthProgression.hasPlant = false;
            EarthProgression.hasOrb = false;
        }
    }
}
