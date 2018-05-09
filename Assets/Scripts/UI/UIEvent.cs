using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEvent : MonoBehaviour {
    // For fps
    //public Text fpsText;
    //float currentFrameTime;
    //float lastFrameTime;
    //float fps;
    //int index = 0;

    public Hero hero;
    public Enemy enemy;
    public Transform increaseBaseDamage;
    public Transform increaseWeaponDamage;
    public Transform increaseWeapon;
    public Transform increaseDamageKoeficient;
    public Transform rearm;
    // Use this for initialization
    void Start () {
        // For fps
        //currentFrameTime = 0;
        //lastFrameTime = -1;
        increaseBaseDamage.Find("Price").GetComponent<Text>().text = hero.priceIncreaseBaseDamage + "";
        increaseBaseDamage.Find("NumberIncreas").GetComponent<Text>().text = hero.baseDamage + "";

        increaseWeaponDamage.Find("Price").GetComponent<Text>().text = hero.priceIncreaseKWeaponDamage + "";
        increaseBaseDamage.Find("NumberIncreas").GetComponent<Text>().text = hero.kWeaponDamage + "";

        increaseWeapon.Find("Price").GetComponent<Text>().text = hero.priceIncreaseWeaponDamage + "";
        increaseBaseDamage.Find("NumberIncreas").GetComponent<Text>().text = hero.weaponDamage + "";

        increaseDamageKoeficient.Find("Price").GetComponent<Text>().text = hero.priceIncreaseKBaseDamage + "";
        increaseBaseDamage.Find("NumberIncreas").GetComponent<Text>().text = hero.kBaseDamage + "";

        rearm.Find("Price").GetComponent<Text>().text = hero.Coins + "";
        //rearm.Find("NumberIncreas").GetComponent<Text>().text = Enemy.moneyForKill + "";
    }

    // Update is called once per frame
    void Update () {
        // For fps
        //currentFrameTime = Time.time;
        //fps = 1 / (currentFrameTime - lastFrameTime);
        //lastFrameTime = currentFrameTime;
        //fpsText.text = fps + "";
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    index = 30;
        //}

        //if (index-- > 0)
        //{
        //    for (int i = 0; i < 200; i++)
        //    {
        //        print(i);
        //    }
        //}
    }

    public void OnSettingsButton()
    {

    }

    public void OnExitButton()
    {

    }

    public void OnIncreaseBaseDamage()
    {
        if (hero.priceIncreaseBaseDamage <= hero.Coins)
        {
            hero.Coins -= hero.priceIncreaseBaseDamage;
            hero.baseDamage += 15;
            hero.priceIncreaseBaseDamage *= 5;
            increaseBaseDamage.Find("Price").GetComponent<Text>().text = hero.priceIncreaseBaseDamage + "";
            increaseBaseDamage.Find("NumberIncreas").GetComponent<Text>().text = hero.baseDamage + "";
        }
    }

    public void OnIncreaseWeaponDamage()
    {
        if (hero.priceIncreaseKWeaponDamage <= hero.Coins)
        {
            hero.Coins -= hero.priceIncreaseKWeaponDamage;
            hero.kWeaponDamage *= 1.01f;
            hero.nWeaponDamage++;
            hero.priceIncreaseKWeaponDamage *= 5;
            increaseWeaponDamage.Find("Price").GetComponent<Text>().text = hero.priceIncreaseKWeaponDamage + "";
            increaseWeaponDamage.Find("NumberIncreas").GetComponent<Text>().text = hero.kWeaponDamage + "";
        }
    }

    public void OnIncreaseWeapon()
    {
        if (hero.priceIncreaseWeaponDamage <= hero.Coins)
        {
            hero.Coins -= hero.priceIncreaseWeaponDamage;
            hero.weaponDamage += hero.weaponStartDamage;
            hero.priceIncreaseWeaponDamage *= 5;
            increaseWeapon.Find("Price").GetComponent<Text>().text = hero.priceIncreaseWeaponDamage + "";
            increaseWeapon.Find("NumberIncreas").GetComponent<Text>().text = hero.weaponDamage + "";
        }
    }

    public void OnIncreaseDamageKoeficient()
    {
        if (hero.priceIncreaseKBaseDamage <= hero.Coins)
        {
            hero.Coins -= hero.priceIncreaseKBaseDamage;
            hero.kBaseDamage *= 1.01f;
            hero.priceIncreaseKBaseDamage *= 2;
            increaseDamageKoeficient.Find("Price").GetComponent<Text>().text = hero.priceIncreaseKBaseDamage + "";
            increaseDamageKoeficient.Find("NumberIncreas").GetComponent<Text>().text = hero.kBaseDamage + "";
        }
    }

    public void OnRearm()
    {

        hero.baseDamage = 15;
        hero.priceIncreaseBaseDamage = 10;
        hero.nWeaponDamage = 1;
        hero.priceIncreaseKWeaponDamage = 10;
        hero.weaponDamage = 15;
        hero.priceIncreaseWeaponDamage = 10;
        hero.Coins = 0;
        Enemy.moneyForKill = 5;
        enemy.maxHealthPoint = 100;
        enemy.HealthPoint = enemy.maxHealthPoint;
        enemy.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1), Random.Range(0f, 1), Random.Range(0f, 1));
    }
}
