using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScrapCollected : MonoBehaviour
{
    public int NumberOfScrap { get; private set; }

    public UnityEvent<ScrapCollected> OnScrapGet;

    public void ScrapGet()
    {
        NumberOfScrap++;
        OnScrapGet.Invoke(this);
    }
}
