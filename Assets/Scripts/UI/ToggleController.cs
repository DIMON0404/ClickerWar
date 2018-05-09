using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour {

    public GameObject obj;

    private void Start()
    {
        GetComponent<Toggle>().isOn = obj.activeInHierarchy;    
    }

    public void OnValueChange()
    {
        obj.SetActive(GetComponent<Toggle>().isOn);
    }
      
}
