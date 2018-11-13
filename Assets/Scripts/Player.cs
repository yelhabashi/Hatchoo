using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public Sprite[] walkSprites;
    int spriteIndex = 0;
    public int health = 0;
    public GameObject MyTissue;
    public AudioClip thrw;
    Vector3 playerPos;
    public int score = 0;
    int enemyRate;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        playerPos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);

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
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstaniateTissue(transform.position + new Vector3(3, 3, 0));
        }

        if(health == 100)
        {
            SceneManager.LoadScene("lose");
        }
    }

    void InstaniateTissue(Vector3 position)
    {
        AudioSource.PlayClipAtPoint(thrw, transform.position);
        Instantiate(MyTissue, position, Quaternion.identity);
    }

    public void IncreaseHealth(int amount)
    {
        health += amount;
    }
    
}
