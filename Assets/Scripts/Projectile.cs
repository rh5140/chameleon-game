// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Projectile : MonoBehaviour {
//     // public GameObject crosshairs;
//     public GameObject player;
//     // public GameObject bulletPrefab;
//     // public GameObject bulletStart;

//     public float bulletSpeed = 60.0f;

//     private Vector3 target;

//     // Use this for initialization
//     void Start () {
//         Cursor.visible = false;
//     }
    
//     // Update is called once per frame
//     void Update () {
//         target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
//         // crosshairs.transform.position = new Vector2(target.x, target.y);

//         Vector3 difference = target - player.transform.position;
//         float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
//         player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

//         // if(Input.GetMouseButtonDown(0)){
//         //     float distance = difference.magnitude;
//         //     Vector2 direction = difference / distance;
//         //     direction.Normalize();
//         //     fireBullet(direction, rotationZ);
//         // }
//     }
//     // void fireBullet(Vector2 direction, float rotationZ){
//     //     GameObject b = Instantiate(bulletPrefab) as GameObject;
//     //     b.transform.position = bulletStart.transform.position;
//     //     b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
//     //     b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
//     // }
// }


// // using System.Collections;
// // using System.Collections.Generic;
// // using UnityEngine;

// // public class Projectile : MonoBehaviour
// // {
// //     public GameObject player;
// //     public GameObject target;

// //     public float speed = 10f;

// //     public Vector3 movePosition;

// //     private float playerX;
// //     private float targetX;
// //     private float nextX;
// //     private float dist;
// //     private float baseY;
// //     private float height;

// //     // Start is called before the first frame update
// //     void Start()
// //     {
// //         player = GameObject.FindGameObjectWithTag("Player");
// //         target = GameObject.FindGameObjectWithTag("Enemy");
// //     }

// //     // Update is called once per frame
// //     void Update()
// //     {
// //         playerX = player.transform.position.x;
// //         targetX = target.transform.position.x;
// //         dist = targetX - playerX;
// //         nextX = Mathf.MoveTowards(transform.position.x, targetX, speed * Time.deltaTime);
// //         baseY = Mathf.Lerp(player.transform.position.y, target.transform.position.y, (nextX - playerX) / dist);
// //         height = 2 * (nextX - playerX) * (nextX - targetX) / (-0.25f * dist * dist);

// //         // movePosition = new Vector2(nextX, baseY + height);

// //         transform.position = movePosition;

// //         if (movePosition == target.transform.position)
// //         {
// //             Destroy(gameObject);
// //         }
// //     }
// // }