// Random movement from https://answers.unity.com/questions/308017/a.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    private Vector3 target;
    private float timer;
    private int sec;
    private bool isCaught;

    // DO NOT use Start since that's for when the object is first instantiated
    // OnEnable since object gets enabled/disabled
    void OnEnable()
    {
        // Spawn at a random height
        transform.position = new Vector3(12, Random.Range(-4f,4f), 0);
        ResetTarget();
        ResetSec();
        isCaught = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Set isCaught false in Projectile
        if (!isCaught)
        {
            timer += Time.deltaTime;
            if (timer > sec)
            {
                ResetTarget();
                ResetSec();
            }
            transform.Translate(target * 10 * Time.deltaTime);
        }
    }

    // Set vector direction
    void ResetTarget()
    {
        target = new Vector3(-0.8f, Random.Range(-0.15f,0.15f), 0f);
    }

    // Set duration of movement in particular direction
    void ResetSec()
    {
        timer = 0;
        sec =  Random.Range(1,2);
    }

    // Call in Projectile
    public void Caught()
    {
        isCaught = true;
    }

}
