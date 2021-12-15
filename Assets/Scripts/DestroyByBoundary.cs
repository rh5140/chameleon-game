using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D col) 
  {
    GameObject collided = col.gameObject;
	if (collided.tag == "Enemy") 
    {
	    collided.SetActive(false);
	}
  }
}
