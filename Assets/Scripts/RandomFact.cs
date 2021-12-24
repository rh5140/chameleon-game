using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomFact : MonoBehaviour
{
    public TextAsset factsList;
    public TextMeshProUGUI displayedFact;

    // Start is called before the first frame update
    void Start()
    {
        List<string> lines = new List<string>(factsList.text.Split('\n'));
        displayedFact.text = lines[Random.Range(0,lines.Count)];
    }
}
