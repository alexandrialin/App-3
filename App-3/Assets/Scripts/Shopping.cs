using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopping : MonoBehaviour
{
    public GameObject shop;
    public GameObject fire_SO;
    public GameObject water_SO;
    public GameObject ice_SO;
    public GameObject earth_SO;
    public Text money;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.hasFire)
        {
            fire_SO.SetActive(true); 
        }
        if (Inventory.hasWater)
        {
            water_SO.SetActive(true);
        }
        if (Inventory.hasIce)
        {
            ice_SO.SetActive(true);
        }
        if (Inventory.hasEarth)
        {
            earth_SO.SetActive(true);
        }
        money.text = "" + Inventory.money;

    }

    public void OpenShop()
    {
        shop.SetActive(true);
    }
    public void CloseShop()
    {
        shop.SetActive(false);
    }
    public void PurchaseFire()
    {
        if(Inventory.money >= 75)
        {
            Inventory.hasFire = true;
            Inventory.money -= 75;
        }
        
    }
    public void PurchaseWater()
    {
        if (Inventory.money >= 75)
        {
            Inventory.hasWater = true;
            Inventory.money -= 75;
        }
    }
    public void PurchaseIce()
    {
        if (Inventory.money >= 75)
        {
            Inventory.hasIce = true;
            Inventory.money -= 75;
        }
    }
    public void PurchaseEarth()
    {
        if (Inventory.money >= 75)
        {
            Inventory.hasEarth = true;
            Inventory.money -= 75;
        }
    }
    public void PurchaseHP()
    {
        if(Inventory.money >= 100)
        {
            OverallHP.hp += 50;
            Inventory.money -= 100;
        }
        
    }

}
