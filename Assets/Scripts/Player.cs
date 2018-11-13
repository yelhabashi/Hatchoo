using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public Sprite[] walkSprites;
    int spriteIndex = 0;
    public int health = 0;
    public GameObject MyTissue;
    public GameObject Enemy;
    private float TissueSpeed = 0;
    public AudioClip thrw;
    Vector3 playerPos;
    public int score = 0;
    //private HealthBar healthbar;

    // Use this for initialization
    void Start ()
    {
        //Invoke("SpawnEnemies", 1);
    }
	
	// Update is called once per frame
	void Update () {

        
        playerPos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);

        //  Pressed Movement  //
        // Moving Forward
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerPos.x = playerPos.x + 0.1f;
            this.transform.position = playerPos;
            this.GetComponent<SpriteRenderer>().sprite = walkSprites[spriteIndex++];
            if (spriteIndex == walkSprites.Length)
            {
                spriteIndex = 0;
            }
        }
        
        // Firing a tissue
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstaniateTissue(transform.position + new Vector3(0, 3, 0));
        }

        // Health Check
        if(health == 100)
        {
            SceneManager.LoadScene("lose");
        }
    }

    void InstaniateTissue(Vector3 position)
    {
        AudioSource.PlayClipAtPoint(thrw, transform.position);
        GameObject TissueObj =  Instantiate(MyTissue,position,Quaternion.identity);
        TissueObj.GetComponent<Rigidbody2D>().velocity = new Vector2(TissueSpeed,0);
    }

    public void IncreaseHealth(int amount)
    {
        health += amount;
    }


    /*void SpawnEnemies()
    {
        print("here");
        Vector3 enemyPos = new Vector3(this.transform.position.x + 7    , this.transform.position.y, 0f);
        GameObject EnemyObj = Instantiate(Enemy, enemyPos, Quaternion.identity);
        EnemyObj.GetComponent<Rigidbody2D>().velocity = new Vector2(EnemySpeed, 0);
    }*/
}
