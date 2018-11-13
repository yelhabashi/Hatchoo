using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;
    public bool destroy;

	// Use this for initialization
	void Start () {
        if(destroy==false)
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
                GameObject.DontDestroyOnLoad(gameObject);
            }
        }
        
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
