using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Sprite[] walkSprites;
    private Player player;
    int spriteIndex = 0;
    Vector3 enemyPos;

    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<Player>();
        Invoke("SpawnEnemy", 2);  
        enemyPos = new Vector3(player.transform.position.x + 30, player.transform.position.y, 0f);
    }
	
	// Update is called once per frame
	void Update ()
    { 
        // Automated Movement //
        enemyPos.x = enemyPos.x - 0.05f;
        this.transform.position = enemyPos;
        this.GetComponent<SpriteRenderer>().sprite = walkSprites[spriteIndex++];
         if (spriteIndex == walkSprites.Length)
             {
                 spriteIndex = 0;
             }
    }

    void SpawnEnemy()
    {
        Instantiate(this, enemyPos, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            HitPlayer();
        }
    }

    void HitPlayer()
    {
        player.IncreaseHealth(10);
        Destroy(gameObject);
    }
}
