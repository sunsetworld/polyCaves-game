using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoringAndLives : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerTxt;
    [SerializeField] TextMeshProUGUI scoreTxt;
    [SerializeField] TextMeshProUGUI livesTxt;
    [SerializeField] killPlayer kP;
    [SerializeField] timer t;
    [SerializeField] CollectingTreasure cT;

    // Start is called before the first frame update
    void Start()
    {
        timerTxt = GetComponent<TextMeshProUGUI>();
        scoreTxt = GetComponent<TextMeshProUGUI>();
        livesTxt = GetComponent<TextMeshProUGUI>();
        kP.GetComponent<killPlayer>();
        t.GetComponent<timer>();
        cT.GetComponent<CollectingTreasure>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
