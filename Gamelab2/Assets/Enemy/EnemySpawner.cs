using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    private float timer;
    public float timerCd = 3;
    private Vector3 spawnPos;

	void Start () {
        spawnPos = transform.position;
        spawnPos.y = enemy.transform.position.y;
	}
	void Update () {
        if (timer < timerCd) {
            timer += Time.deltaTime;
        }
        else {
            Instantiate(enemy, spawnPos, enemy.transform.rotation);
            timer -= timerCd;
        }
	}
}
