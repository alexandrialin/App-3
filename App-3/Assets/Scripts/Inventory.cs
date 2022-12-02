using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static int money = 0;
    public static bool hasFire;
    public static bool hasIce;
    public static bool hasWater; 
    public static bool hasEarth;

    // Start is called before the first frame update
    public static void ResetStats()
    {
        money = 0;
        hasFire = false;
        hasIce = false;
        hasWater = false;
        hasEarth = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
