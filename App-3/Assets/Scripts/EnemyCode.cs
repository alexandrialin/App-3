using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyCode : MonoBehaviour
{

    public float attackSpeed = 4;
    public float attackDistance;
    public float bufferDistance;
    public GameObject player;
    public GameObject green;
    public GameObject teal;
    public GameObject orange;
    public GameObject blue;
    public Animator anim;
    public float distance;
    public Text hpText;
    public int hp = 100;
    public Text dmgText;
    public int dmg;
    public bool fairy = false;
    public string enemyType;
    public float lag = 0;
    public float enemyLag = 0;
    public float cooldown = 0;
    public float dmgTime = 0;
    public float deathTime = 2f;
    public bool alive = true;
    public CharacterSwitch cs;
    public GameObject projectile;
    public GameObject FirePoint;

    Transform playerTransform;

    void GetPlayerTransform()
    {
        if (player != null)
        {
            playerTransform = player.transform;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GetPlayerTransform();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(playerTransform.position, transform.position);
        if (Mathf.Abs(distance) <= attackDistance)
        {
            if (Mathf.Abs(distance) >= bufferDistance)
            {
                transform.LookAt(player.transform);
                transform.position += transform.forward * attackSpeed * Time.deltaTime;
                anim.SetInteger("attack", 1);
                if(fairy == true && enemyLag <= 0)
                {
                    Instantiate(projectile, FirePoint.transform.position, FirePoint.transform.rotation);
                    enemyLag = 1f;
                }
            }
        }
        else
        {
            anim.SetInteger("attack", 0);
        }

        if (Input.GetMouseButton(0) && lag <= 0f)
        {
            EnemyStun(cs.attackDistance, cs.targetName, 1);
            lag = 0.5f;
        }
        if (Input.GetMouseButton(1) && HumanP1.ultActive == true)
        {
            EnemyStun(cs.ultDistance, cs.targetName, 2);
        }
        if (lag > 0)
        {
            lag -= Time.deltaTime;
        }
        if (enemyLag > 0)
        {
            enemyLag -= Time.deltaTime;
        }

        if (dmgTime > 0)
        {
            if(cs.targetName == "blue")
            {
                dmgText.color = Color.blue;
            }
            if (cs.targetName == "orange")
            {
                dmgText.color = Color.red;
            }
            if (cs.targetName == "teal")
            {
                dmgText.color = Color.cyan;
            }
            if (cs.targetName == "green")
            {
                dmgText.color = Color.green;
            }
            dmgText.text = "" + dmg;
            dmgTime -= Time.deltaTime;
        }
        else
        {
            dmgText.text = "";
        }
        if(hp <= 0)
        {
            hp = 0;
            hpText.text = "0/100";
            anim.SetInteger("attack", 4);
            alive = false;



        }
        if (deathTime > 0 && alive == false)
        {
            deathTime -= Time.deltaTime;
        }
        else if(deathTime <= 0)
        {
            if (gameObject.CompareTag("3fires"))
            {
                GameProgression.fireballs++;
            }
            Destroy(gameObject);
        }

        if (cs.targetName == "green")
        {
            player = green;
            GetPlayerTransform();
        }
        if (cs.targetName == "blue")
        {
            player = blue;
            GetPlayerTransform();
        }
        if (cs.targetName == "orange")
        {
            player = orange;
            GetPlayerTransform();
        }
        if (cs.targetName == "teal")
        {
            player = teal;
            GetPlayerTransform();
        }

    }

    public void SetPlayer(GameObject player)
    {
        this.player = player;
    }

    public void EnemyStun(int abilityDistance, string mcType, int skill)
    {
        if (Mathf.Abs(distance) < abilityDistance)
        {
            anim.SetInteger("attack", 3);
            // setting dmg numbers
            if (skill == 1)
            {
                if (mcType == "green" || enemyType == "green")
                {
                    dmg = Random.Range(10, 20);
                }
                else if (mcType == "blue")
                {
                    if (enemyType == "orange")
                    {
                        dmg = Random.Range(10, 20);
                    }
                    if (enemyType == "teal")
                    {
                        dmg = Random.Range(20, 30);
                    }
                    if(enemyType == "blue")
                    {
                        dmg = 0;
                    }
                }
                else if (mcType == "orange")
                {
                    if (enemyType == "blue")
                    {
                        dmg = Random.Range(10, 20);
                    }
                    if (enemyType == "teal")
                    {
                        dmg = Random.Range(5, 10);
                    }
                    if (enemyType == "orange")
                    {
                        dmg = 0;
                    }
                }
                else if (mcType == "teal")
                {
                    if (enemyType == "blue")
                    {
                        dmg = Random.Range(5, 10);
                    }
                    if (enemyType == "orange")
                    {
                        dmg = Random.Range(10, 20);
                    }
                    if (enemyType == "teal")
                    {
                        dmg = 0;
                    }
                }
            }
            if (skill == 2)
            {
                if (mcType == "green" || enemyType == "green")
                {
                    dmg = Random.Range(20, 30);
                }
                else if (mcType == "blue")
                {
                    if (enemyType == "orange")
                    {
                        dmg = Random.Range(10, 20);
                    }
                    if (enemyType == "teal")
                    {
                        dmg = Random.Range(30, 40);
                    }
                    if (enemyType == "blue")
                    {
                        dmg = 0;
                    }
                }
                else if (mcType == "orange")
                {
                    if (enemyType == "blue")
                    {
                        dmg = Random.Range(30, 40);
                    }
                    if (enemyType == "teal")
                    {
                        dmg = Random.Range(10, 20);
                    }
                    if (enemyType == "orange")
                    {
                        dmg = 0;
                    }
                }
                else if (mcType == "teal")
                {
                    if (enemyType == "blue")
                    {
                        dmg = Random.Range(10, 20);
                    }
                    if (enemyType == "orange")
                    {
                        dmg = Random.Range(30, 40);
                    }
                    if (enemyType == "teal")
                    {
                        dmg = 0;
                    }
                }
            }
            hpText.text = hp - dmg + "/100";
            hp -= dmg;
            dmgTime = 1f;
           
        }
    }
}