using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatCollider : MonoBehaviour {

    private RepeatingBackground repeatingBackground;

    // Use this for initialization
    void Start()
    {
        repeatingBackground = GameObject.FindObjectOfType<RepeatingBackground>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(gameObject.name == "RepeatCollider")
        {
            if (collision.gameObject.tag == "Player")
            {
                repeatingBackground.RepositionBackground();
            }
        }
        else if(gameObject.name == "DestroyCollider")
        {
            if(collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);
            }
        }
        
        

    }
}
