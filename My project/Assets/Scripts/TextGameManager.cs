using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public int hpValue, sanValue;

    public string startOfStory;

    public TextMeshProUGUI healthValue, sanityValue, mainTitle;

    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        sanValue = 10;
        startOfStory = "I just woke up";
    }

    // Update is called once per frame
    void Update()
    {
        healthValue.text = hpValue.ToString();
        sanityValue.text = sanValue.ToString();
        mainTitle.text = startOfStory;
    }

    public void getUpBtn()
    {
        hpValue -= 10;
        startOfStory = "YOU DIED!";
    }

    public void sleepBtn()
    {
        hpValue -= 10;
        startOfStory = "YOU DIED AGAIN!";
    }
}
