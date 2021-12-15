using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
  void OnTriggerExit2D(Collider2D col) 
  {
    GameObject collided = col.gameObject;
	if (collided.tag == "Enemy") 
    {
        Debug.Log(collided.activeSelf);
	    collided.SetActive(false);
        Debug.Log(collided.activeSelf);
	}
  }
}
