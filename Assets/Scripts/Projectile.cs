// Tutorial used as base: Press Start's "Unity - Point and Shoot Tutorial" https://www.youtube.com/watch?v=7-8nE9_FwWs
// Thanks to RICHARD and MING for advice

// TO DO:
// Probably separate player movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour 
{
    public GameObject player;
    public GameObject crosshairs;
    public GameObject camera;
    
    public bool tongueOut;
    public float projectileSpeed = 20.0f;

    private Vector3 cursorPosition;
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private Vector3 difference;
    private float distance;
    private float duration;
    private bool collidedWithBug;

    void Start()
    {
        collidedWithBug = false;
        tongueOut = false;
    }

    void Update()
    {
        cursorPosition = camera.transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        crosshairs.transform.position = new Vector2(cursorPosition.x, cursorPosition.y);

        // Rotate chameleon head to face cursor
        difference = cursorPosition - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        rotationZ = Mathf.Clamp (rotationZ, -60, 60);
        if (!tongueOut)
        {
            player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (Input.GetMouseButtonDown(0))
        {
            // Snapshot cursor position for target
            targetPosition = cursorPosition;
            difference = targetPosition - player.transform.position;
            distance = difference.magnitude;
            // time = distance / rate
            duration = distance / projectileSpeed;
            Vector2 direction = difference / distance;
            direction.Normalize();
            if (!tongueOut)
            {
                StartCoroutine(Tongue(direction, rotationZ));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Pre collision collidedWithBugValue = " + collidedWithBug);

        collidedWithBug = true;

        Destroy(col.gameObject);

        Debug.Log("Post collision collidedWithBugValue = " + collidedWithBug);

    }
    IEnumerator Tongue(Vector2 direction, float rotationZ)
    {
        tongueOut = true;

        // TO DO: object pooling w/ this one tongue projectile
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;

        startPosition = transform.position;
        float time = 0;

        // Lerp between spawn point and click point
        while (time < duration && !collidedWithBug)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        
        // Get position again in case hit bug before click point
        targetPosition = transform.position;
        // Lerp back to spawn point
        difference = targetPosition - player.transform.position;
        distance = difference.magnitude;
        duration = distance / projectileSpeed;
        time = 0;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(targetPosition, startPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }    

        collidedWithBug = false;
        tongueOut = false;
        yield return null;
    }
}
