using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {
    private static int numberOfEnemy = 1;
    public int maxHealthPoint = 100;
    private int _healthPoint;
    public int HealthPoint
    {
        get
        {
            return _healthPoint;
        }
        set
        {
            _healthPoint = value;
            uIController.SetHealthBarValue(_healthPoint, maxHealthPoint);
        }
    }

    string nameEnemy;

    public UIController uIController;
    public Hero hero;
    public static float moneyForKill;

	// Use this for initialization
	void Start () {
        moneyForKill = 5;
        HealthPoint = maxHealthPoint;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void GetDamage(int damageValue)
    {
        HealthPoint = HealthPoint - damageValue;
        print(damageValue);
        if (HealthPoint <= 0)
        {
            Death();
        }
        //GetComponent<Animator>().SetTrigger("GetDamage");
    }

    private void Death()
    {
        moneyForKill *= 1.2f;
        hero.Coins += (int)moneyForKill;
        maxHealthPoint = (int)(maxHealthPoint * Mathf.Pow(1.01f, ++numberOfEnemy));
        HealthPoint = maxHealthPoint;
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1), Random.Range(0f, 1), Random.Range(0f, 1));
    }
}
