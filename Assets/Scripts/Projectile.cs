using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour 
{
    public bool collidedWithBug = false;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Pre collision collidedWithBugValue = " + collidedWithBug);

        collidedWithBug = true;

        Destroy(col.gameObject);
        
        Debug.Log("Post collision collidedWithBugValue = " + collidedWithBug);

    }
}
