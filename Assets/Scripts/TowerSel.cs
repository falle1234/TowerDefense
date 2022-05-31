using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSel : MonoBehaviour
{
    [SerializeField] int towerIndex;
    [SerializeField] int cost = 100;
    SpriteRenderer spriteRenderer;
    GameMaster gameMasterObj;
    GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameMasterObj = GameObject.Find("GameMaster").GetComponent<GameMaster>();
        circle = transform.Find("Circle").gameObject;
    }


    // Update is called once per frame
    void Update()
    {
        if (gameMasterObj.money >= cost)
        {
            spriteRenderer.enabled = true;
            circle.SetActive(gameMasterObj.towerSelected == towerIndex);
        }
        else
        {
            spriteRenderer.enabled = false; 
            circle.SetActive(false);
            if (gameMasterObj.towerSelected == towerIndex)
                gameMasterObj.towerSelected = -1;
        }
    }

    private void OnMouseDown()
    {
        gameMasterObj.towerSelected = towerIndex;
        gameMasterObj.towerCost = cost;
    }
}
