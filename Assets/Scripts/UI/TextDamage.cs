using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDamage : MonoBehaviour {

    private Vector3 targetPosition = new Vector3(0, 0, 0);      // Место куда двигатся
	// Use this for initialization
	void Start () {
        StartCoroutine(DestroyThis());
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);   // Немного перемещения
	}

    // Через некоторое время текст исчезнет
    private IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
     
    public void SetParametrs(int damage, Vector3 position)
    {
        transform.position = position;
        // Целевую точку определяем с немного выше врага с небольшим рандомом
        targetPosition = transform.position + new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(0f, 3f),
            Random.Range(0.5f, 2f)
            );
        GetComponent<TextMesh>().text = damage + "";
        GetComponent<TextMesh>().characterSize = (damage - 1) * 0.0002f + 1;            // Чем больше урон, тем больше текст
        GetComponent<TextMesh>().color = new Color(1, 1 - (float)damage / 5000, 0, 1);  // Цвет текста изменяется в градиенте от желтого до красного в зависимости от размера урона
    }
}
