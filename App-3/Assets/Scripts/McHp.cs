using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class McHp : MonoBehaviour
{
    public static int hp = 200;
    public Text hpText;
    public AudioSource squeal;
    // to make sure the squeals don't get too annoying
    public float squealCooldown;
    public string type;
    public GameObject deathScreen;
    public GameObject leaderboard;

    private void Start()
    {
        deathScreen.SetActive(false);
        hp = 200;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(type))
        {
            Destroy(collision.gameObject);
            
        }
        if (!collision.gameObject.CompareTag(type) && (collision.gameObject.CompareTag("water") || collision.gameObject.CompareTag("ice") || collision.gameObject.CompareTag("fire") || collision.gameObject.CompareTag("earth")) )
        {
            hp -= 100;
            if (squealCooldown <= 0)
            {
                Instantiate(squeal);
            }

            squealCooldown = 1f;
        }
        

        if(collision.gameObject.CompareTag("body"))
        {
            hp -= 10;
            if (squealCooldown <= 0)
            {
                Instantiate(squeal);
            }
            squealCooldown = 1f;
        }
        if(collision.gameObject.CompareTag("hit"))
        {
            hp -= 5;
            if (squealCooldown <= 0)
            {
                Instantiate(squeal);
            }
            squealCooldown = 1f;
        }
        if(collision.gameObject.CompareTag("Finish"))
        {
            leaderboard.SetActive(true);
        }
        hpText.text = hp + "/200";

    }
    void Update()
    {
        if(squealCooldown > 0)
        {
            squealCooldown -= Time.deltaTime;
        }
        if (hp <= 0)
        {
            deathScreen.SetActive(true);
        }
    }
    
}
