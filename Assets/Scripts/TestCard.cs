using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCard : BaseCard
{
    // Start is called before the first frame update
    void Start()
    {
        objectName = "Star";
        objectType = "Star";
        cardCost = 5;
        info = "This is a star";
        DisplayText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
