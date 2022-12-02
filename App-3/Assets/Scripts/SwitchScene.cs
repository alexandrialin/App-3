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
    public void DestroyMenu()
    {
        Destroy(gameObject);
    }
    public void HubWorld()
    {
        SceneManager.LoadScene("HubWorld");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Prologue");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        GameProgression.ResetEarth();
        GameProgression.ResetFire();
        Inventory.ResetStats();

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
                GameProgression.ResetFire();
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
            GameProgression.ResetEarth();
        }
    }
}
