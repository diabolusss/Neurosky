using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public uint speed = 3;

	void Update () {
        transform.Translate(Vector2.right * -Time.deltaTime * speed);
	}
    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
