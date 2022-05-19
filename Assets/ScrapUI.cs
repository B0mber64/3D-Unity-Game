using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrapUI : MonoBehaviour
{
    private TextMeshProUGUI scrapText;

    // Start is called before the first frame update
    void Start()
    {
        scrapText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScrapText(ScrapCollected scrapCollected)
    {
        scrapText.text = "Scrap Collected: "+scrapCollected.NumberOfScrap+"/8";
    }
}
