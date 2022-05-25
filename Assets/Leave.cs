using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leave : MonoBehaviour
{
    public WinScreen winScreen;

    public ScrapCollected scrapCollected;

    private void OnTriggerEnter()
    {

        if (scrapCollected.NumberOfScrap == 8)
        {
            winScreen.Win();
        }
    }
}
