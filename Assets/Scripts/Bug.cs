using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        // Spawn at a random height
        transform.position = new Vector3(12, Random.Range(-4,4), 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Just move to the left
        transform.position += new Vector3(-0.005f, 0.0f, 0.0f);
    }
    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     // Attach to tongue?!!?
    // }
}
