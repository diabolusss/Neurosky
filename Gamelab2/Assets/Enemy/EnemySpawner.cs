using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy1;
    public GameObject enemy2;
    private float timer;
    public float timerCd = 3;
    private Vector3 spawnPos;

	void Start () {
        spawnPos = transform.position;
        spawnPos.y = enemy1.transform.position.y;
	}
	void Update () {
        if (timer < timerCd) {
            timer += Time.deltaTime;
        }
        else {
            int number = Random.Range(0, 2);
            GameObject enemy;
            if (number == 0) {
                enemy = enemy1;
            }
            else {
                enemy = enemy2;
            }
            Instantiate(enemy, spawnPos, enemy.transform.rotation);
            timer -= timerCd;
        }
	}
}
