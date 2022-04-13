using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class scoreDisplay : MonoBehaviour
{
    [SerializeField] CollectingTreasure cT;
    [SerializeField] TextMeshProUGUI scoreTxt;
    public float score;


    // Start is called before the first frame update
    void Start()
    {
        if (cT != null)
        {
            cT.GetComponent<CollectingTreasure>();
            cT.GetScore();
        }

        if (scoreTxt != null)
        {
            scoreTxt.GetComponent<TextMeshProUGUI>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        DisplayScore();
    }

    public void DisplayScore()
    {
        if (cT != null)
        {
            score = cT.GetComponent<CollectingTreasure>().GetScore();
        }

        if (scoreTxt != null)
        {
            scoreTxt.text = "You scored " + score.ToString();
        }
    }
}
