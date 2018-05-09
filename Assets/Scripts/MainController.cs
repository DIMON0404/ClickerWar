using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

    public Enemy currentEnemy;
    public Hero currentHero;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            //currentEnemy.GetDamage(currentHero.damage);
            //currentEnemy.GetComponent<Animator>().Play("DamageAnim");
        }
	}

    public void DestroyEnemy(Enemy enemy)
    {

    }
}
;