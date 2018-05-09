using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public UIController uIController;
    private int _coins = 0;
    public int Coins
    {
        get { return _coins; }
        set {
            _coins = value;
            uIController.SetCoins(_coins);
        }
    }

    public float baseDamage = 15;
    public int priceIncreaseBaseDamage = 10;
    //public int nBaseDamage = 1;

    public float kBaseDamage = 1.0f;
    public int priceIncreaseKBaseDamage = 10;

    public float weaponStartDamage = 15;
    public float weaponDamage = 15;
    public int priceIncreaseWeaponDamage = 10;

    public float kWeaponDamage = 1f;
    public int priceIncreaseKWeaponDamage = 10;
    
    public int nWeaponDamage = 1;

    public int Damage
    {
        get { return (int)(baseDamage + weaponDamage * Mathf.Pow(nWeaponDamage, kWeaponDamage) * kBaseDamage); }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
