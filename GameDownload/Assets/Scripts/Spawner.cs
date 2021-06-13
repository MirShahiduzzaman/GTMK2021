using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject theEnemy;
    public int xPos;
    public int yPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 7)
        {
            xPos = Random.Range(-10, 12);
            yPos = Random.Range(-5, 7);

            Instantiate(theEnemy, new Vector3(xPos, yPos, -31), Quaternion.identity);
            yield return new WaitForSeconds(0.2F);
            enemyCount += 1;
        }
    }


}
    