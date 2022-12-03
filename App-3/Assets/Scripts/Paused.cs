using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    public float pauseTime;
    public GameObject pauseMenu;
    public GameObject newPause;
    public bool paused;


    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseTime > 0)
        {
            pauseTime -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Escape) && pauseTime <= 0 && paused == false)
        {

            newPause = Instantiate(pauseMenu);
            pauseTime = 1f;
            paused = true;

        }
        if (Input.GetKey(KeyCode.Escape) && pauseTime <= 0 && paused == true)
        {
            Destroy(newPause);
            paused = false;
        }

    }
}
