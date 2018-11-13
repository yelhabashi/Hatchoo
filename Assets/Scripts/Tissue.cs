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
        Invoke("SelfDestruct", 2);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x + 0.1f, transform.position.y, transform.position.z);
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
