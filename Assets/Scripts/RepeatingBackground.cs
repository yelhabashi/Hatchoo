using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour
{
    private void Start()
    {
        
    }
    
    private void Update()
    {
        
    }
    
    public void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(32 , 0);
        transform.position = (Vector2)transform.position + groundOffSet;

    }
}
