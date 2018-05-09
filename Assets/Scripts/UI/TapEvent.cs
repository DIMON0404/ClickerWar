using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapEvent : MonoBehaviour {

    public Enemy enemy;
    public Hero hero;
	// Update is called once per frame
	void Update () {
	}

    private void OnMouseDown()
    {
		if (Input.GetMouseButtonDown(0))
        {
            enemy.GetDamage(hero.Damage);
        }
        
    }
}
