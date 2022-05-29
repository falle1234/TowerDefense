using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float hitDiv = 10;
    [SerializeField] GameObject barObj;
    int path;
    float health;


    // Start is called before the first frame update
    void Start()
    {
        path = 0;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x > -16) && (path == 0))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            path++;
        }
        else if ((transform.position.y > 12f) && (path == 1))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            path++;
        }
        else if ((transform.position.x > 8f) && (path == 2))
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
            path++;
        }
        else if ((transform.position.y < -16f) && (path == 3))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            path++;
        }
        else if ((transform.position.x > 24f) && (path == 4))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            path++;
        }
        else if ((transform.position.y > 0f) && (path == 5))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            path++;
        }
        else if ((transform.position.x > 31f) && (path == 6))
        {
            GameObject.Find("Gameover").GetComponent<TMPro.TMP_Text>().enabled = true;
            path++;
        }


        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void Hit(float impact)
    {
        health -= impact / hitDiv;
        if (health <= 0)
        {
            // Dead
            Destroy(gameObject);
        }
        else
            barObj.transform.localScale = new Vector3(health / 100, 1, 1);

    }
}
