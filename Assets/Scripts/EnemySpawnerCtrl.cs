using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerCtrl : MonoBehaviour
{
    [SerializeField] GameObject[] enemiesObj;
    int enemySel;
    float timerS;
    float delayS;
    float nextS;

    // Start is called before the first frame update
    void Start()
    {
        delayS = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timerS += Time.deltaTime;
        nextS += Time.deltaTime;

        if ((timerS < 1) && (timerS+Time.deltaTime > 1))
        {
            delayS = 1;
            enemySel = 0;
        }

        if (nextS > delayS)
        {
            Instantiate(enemiesObj[enemySel], transform.position, transform.rotation);
            nextS = 0;
        }
    }
}
