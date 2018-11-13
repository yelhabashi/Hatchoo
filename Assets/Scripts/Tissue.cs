using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tissue : MonoBehaviour
{

    public AudioClip hit;
    private Vector3 objectSpawnPosition;
    private Player player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        GetComponent<Rigidbody2D>().velocity = new Vector2(7, 0);
        Invoke("SelfDestruct", 2);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(hit, transform.position);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            player.score += 10;
        }
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }

}
