using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgression : MonoBehaviour
{
    public static bool hasKey = false;
    public static bool hasChest = false;
    public static int numTorches = 0;
    public static int fireballs = 0;
    public static bool iceMelt = false;
    public GameObject enemies;
    public GameObject key;
    public GameObject chest;
    public GameObject complete;

    public static bool waterComplete = false;
    public static bool iceComplete = false;
    public static bool fireComplete = false;
    public static bool earthComplete = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey && hasChest && iceMelt)
        {
            chest.SetActive(false);
            complete.SetActive(true);

        }
        if (numTorches == 3)
        {
            enemies.SetActive(true);
        }
        if (fireballs == 3)
        {
            key.SetActive(true);
            fireballs = 0;
        }
    }
}
