using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public GameObject healthBar;
    public Text coins;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetHealthBarValue(int value, int maxValue)
    {
        if (value < 0)
        {
            value = 0;
        }
        healthBar.GetComponent<Image>().fillAmount = (float)value / maxValue;
        healthBar.transform.GetChild(0).GetComponent<Text>().text = value + "";
    }

    public void SetCoins(int coinsValue)
    {
        coins.text = coinsValue + "";
    }
}
