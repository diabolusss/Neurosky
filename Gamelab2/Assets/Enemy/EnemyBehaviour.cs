using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    public uint speed;
    public int damage;
    public int life;
    public int enemyType;

    void start()
    {
        speed = 3;
        damage = 10;
        life = 10;
    }

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
