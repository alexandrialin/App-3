using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters;
using System;

public class AbilityShooting : MonoBehaviour
{
    public GameObject FirePoint;
    public Camera Cam;
    public float MaxLength;
    public GameObject[] Prefabs;

    private Ray RayMouse;
    private Vector3 direction;
    private Quaternion rotation;

    [Header("GUI")]
    private float windowDpi;
    private int Prefab;
    private GameObject Instance;
    private float hSliderValue = 0.1f;
    private float fireCountdown = 0f;
    public float lag = 0;
    public float cooldown = 0;
    //Double-click protection
    private float buttonSaver = 0f;
    public GameObject ability;
    public GameObject ult;
    public GameObject ultSound;

    //For Camera shake 
    //public Animation camAnim;

    void Start()
    {
        if (Screen.dpi < 1) windowDpi = 1;
        if (Screen.dpi < 200) windowDpi = 1;
        else windowDpi = Screen.dpi / 200f;
        Prefab = 0;
    }

    void Update()
    {
        //Single shoot
        if (Input.GetButtonDown("Fire1") && lag <= 0f)
        {
            // camAnim.Play(camAnim.clip.name);
            Instantiate(ability, FirePoint.transform.position, FirePoint.transform.rotation);
            lag = 0.5f;
        }

        //Ult shooting
        if (Input.GetMouseButton(1) && cooldown <= 0f)
        {
            Instantiate(ult, FirePoint.transform.position, FirePoint.transform.rotation);
            Instantiate(ultSound);
            cooldown = 10f;
        }
        fireCountdown -= Time.deltaTime;


        buttonSaver += Time.deltaTime;
        if (lag > 0)
        {
            lag -= Time.deltaTime;
        }
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Prefab = 0;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Prefab = 1;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Prefab = 2;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Prefab = 3;
        }
    }


/*    // To change prefabs (count - prefab number)
    void Counter(int count)
    {
        Prefab += count;
        if (Prefab > Prefabs.Length - 1)
        {
            Prefab = 0;
        }
        else if (Prefab < 0)
        {
            Prefab = Prefabs.Length - 1;
        }
    }*/


}
