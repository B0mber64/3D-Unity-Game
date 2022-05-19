using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leave : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScrapCollected scrapCollected = other.GetComponent<ScrapCollected>();

        if (scrapCollected.NumberOfScrap == 8)
        {
            
        }
    }
}
