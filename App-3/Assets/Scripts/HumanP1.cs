using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HumanP1 : MonoBehaviour
{
    float speed = 6f;
    float rotSpeed = 80;
    float gravity = 8;
    public Animator anim;
    // Start is called before the first frame update
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
/*    public GameObject projectile;
    public GameObject ult;*/
    public static bool ultActive = true;
    public GameObject FirePoint;
    public float cooldown = 0;
    public float lag = 0;
    public Text cdText;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
            {
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
            if (Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.UpArrow))
            {
                anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
            {
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, -1);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 180, 0);

            }
            if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(1, 0, 0);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 90, 0);

            }
            if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                anim.SetInteger("condition", 1);
                moveDir = new Vector3(-1, 0, 0);
                moveDir *= speed;
                transform.eulerAngles = new Vector3(0, 270, 0);

            }
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.SetInteger("condition", 0);

                moveDir = new Vector3(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetInteger("jump", 1);



            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                anim.SetInteger("jump", 0);
            }
            if (Input.GetKey(KeyCode.X))
            {
                anim.SetInteger("fight", 1);



            }
            if (Input.GetKeyUp(KeyCode.X))
            {
                anim.SetInteger("fight", 0);
            }
            if (Input.GetMouseButtonDown(0) && lag <= 0f)
            {
                anim.SetInteger("fight", 1);

                lag = 0.5f;

            }
            if (Input.GetMouseButtonDown(1) && cooldown <= 0f)
            {
                anim.SetInteger("fight", 2);

                cooldown = 10f;

            }
            if (lag > 0)
            {
                lag -= Time.deltaTime;
            }
            if (cooldown > 0)
            {

                cooldown -= Time.deltaTime;
                cdText.text = cooldown + "";
                ultActive = false;
            }
            else
            {
                ultActive = true;
                cdText.text = "RC";
            }
            if (Input.GetMouseButtonUp(0))
            {
                anim.SetInteger("fight", 0);
            }
            if (Input.GetMouseButtonUp(1))
            {
                anim.SetInteger("fight", 0);
            }
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
    void OnTriggerEnter(Collider other)
    {

        other.isTrigger = false;




    }
}