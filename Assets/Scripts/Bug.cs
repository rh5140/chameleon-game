using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    // DO NOT use Start since that's for when the object is first instantiated
    // OnEnable since object gets enabled/disabeled
    void OnEnable()
    {
        // Spawn at a random height
        transform.position = new Vector3(12, Random.Range(-4f,4f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Just move to the left
        transform.position += new Vector3(-0.01f, 0.0f, 0.0f);
    }
    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     // Attach to tongue?!!?
    // }
}
