// Tutorial used as base: Press Start's "Unity - Point and Shoot Tutorial" https://www.youtube.com/watch?v=7-8nE9_FwWs
// Thanks to RICHARD and MING for advice

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject player;
    // public GameObject projectile;
    public GameObject projectilePrefab;
    public GameObject crosshairs;

    private Vector3 startPosition;
    private Vector3 cursorPosition;
    private Vector3 targetPosition;
    private bool tongueOut;
    private float duration;

    public float projectileSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
        // startPosition = projectile.transform.position;
        tongueOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        cursorPosition = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        crosshairs.transform.position = new Vector2(cursorPosition.x, cursorPosition.y);

        // Rotate chameleon head to face cursor
        // Need to limit rotation since chameleon can't turn head all the way around...
        Vector3 difference = cursorPosition - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        
        if (Input.GetMouseButtonDown(0))
        {
            // Snapshot cursor position for target
            targetPosition = cursorPosition;
            difference = targetPosition - player.transform.position;
            float distance = difference.magnitude;
            // time = distance / rate
            duration = distance / projectileSpeed;
            Vector2 direction = difference / distance;
            direction.Normalize();
            if (tongueOut == false)
            {
                StartCoroutine(Tongue(direction, rotationZ));
            }
        }
    }
    IEnumerator Tongue(Vector2 direction, float rotationZ)
    {
        tongueOut = true;

        // Replace w/ persistent projectile later
        GameObject b = Instantiate(projectilePrefab) as GameObject;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;

        startPosition = projectilePrefab.transform.position;
        float time = 0;

        // Lerp between spawn point and click point
        while (time < duration)
        {
            b.transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            // If collide, break
            yield return null;
        }
        
        b.transform.position = targetPosition;
        // Lerp back to spawn point
        time = 0;
        while (time < duration)
        {
            b.transform.position = Vector3.Lerp(targetPosition, startPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }    

        // Won't be necessary later
        Destroy(b);
        tongueOut = false;
        yield return null;
    }
}
