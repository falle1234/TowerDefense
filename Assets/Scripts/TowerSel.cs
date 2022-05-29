using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSel : MonoBehaviour
{
    [SerializeField] int towerIndex;
    GameMaster gameMasterObj;
    GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        gameMasterObj = GameObject.Find("GameMaster").GetComponent<GameMaster>();
        circle = transform.Find("Circle").gameObject;
    }


    // Update is called once per frame
    void Update()
    {
        circle.SetActive(gameMasterObj.towerSelected == towerIndex);
    }

    private void OnMouseDown()
    {
        gameMasterObj.towerSelected = towerIndex;
    }
}
