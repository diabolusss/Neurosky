using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    TGCConnectionController controller;

    public uint speed;
    private int maxdamage;
    public int damage;
    public int life;
    public int enemyType;

    void start()
    {
        maxdamage = damage;
        speed = 3;
        damage = 10;
        life = 10;
		controller = GameObject.Find("NeuroSkyTGCController").GetComponent<TGCConnectionController>();
		
		controller.UpdateMeditationEvent += OnUpdateMeditation;
    }

    private void OnUpdateMeditation(int value) {
        damage = Mathf.RoundToInt((value / 100) * maxdamage);
    }

	void Update () {
        transform.Translate(Vector2.right * -Time.deltaTime * speed);
	}
    void OnBecameInvisible() {
        Destroy(gameObject);
    }
    void OnDestroy() {
        Score.thisScript.AddScore(1);
    }
}
