using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScrapCollected scrapCollected = other.GetComponent<ScrapCollected>();

        if (scrapCollected != null)
        {
            scrapCollected.ScrapGet();
            gameObject.SetActive(false);
        }
    }
}
