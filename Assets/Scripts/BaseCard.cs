using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BaseCard : MonoBehaviour
{
    protected string objectName = "";
    protected string objectType = "";
    protected string info = "";
    protected int cardCost = 0;

    [SerializeField] protected GameObject objImage;
    [SerializeField] protected TMP_Text cardText;
    [SerializeField] protected TMP_Text titleText;
    [SerializeField] protected TMP_Text costText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void DisplayText()
    {
        titleText.text = objectName;
        cardText.text = "Type: " + objectType + "\n" + info;
        costText.text = cardCost.ToString();
    }
}
