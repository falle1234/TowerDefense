using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    [System.NonSerialized] 
    public int towerSelected = -1;
    [System.NonSerialized]
    public bool gameover = false;
    [System.NonSerialized] 
    public int towerCost = 0;
    [System.NonSerialized] 
    public int money = 200;

    [SerializeField]
    TMPro.TMP_Text moneyTextField;

    [SerializeField]
    TMPro.TMP_Text timeTextField;

    float timeLevelStarted;
    // Start is called before the first frame update
    void Start()
    {
        timeLevelStarted = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            var elapsedTime = Time.time - timeLevelStarted;
            timeTextField.text = $"Time : {(int)(elapsedTime / 60):00}:{(int)(elapsedTime % 60):00}";
            moneyTextField.text = $"$ {money}";
        }
    }
}
