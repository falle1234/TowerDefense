using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCtrl : MonoBehaviour
{
    [SerializeField] GameObject[] towersObj;
    GameObject currentTower;
    GameMaster gameMasterObj;


    // Start is called before the first frame update
    void Start()
    {
        gameMasterObj = GameObject.Find("GameMaster").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (currentTower == null && gameMasterObj.towerSelected >=0 && gameMasterObj.money >= gameMasterObj.towerCost)
        {
            gameMasterObj.money -= gameMasterObj.towerCost;
            currentTower = Instantiate(towersObj[gameMasterObj.towerSelected], transform.position, transform.rotation);
        }
    }
}
