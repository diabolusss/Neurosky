using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    public uint speed = 3;
    public int damage = 10;
    public int life = 10;
    public int enemyType;

    void Awake() {
        enemyType = Random.Range(1, 3);
        Debug.Log(enemyType);
    }

	void Update () {
        transform.Translate(Vector2.right * -Time.deltaTime * speed);
	}
    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
