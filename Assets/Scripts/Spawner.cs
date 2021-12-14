using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private bool spawningNow;

    // Start is called before the first frame update
    void Start()
    {
        spawningNow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawningNow)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        spawningNow = true;
        GameObject bug = ObjectPool.SharedInstance.GetPooledObject();
        if (bug != null)
        {
            bug.SetActive(true);
        }
        spawningNow = false;
        yield return new WaitForSeconds(2.0f);
    }
}
