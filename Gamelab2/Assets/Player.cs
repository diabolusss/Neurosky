using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private int _enemyType;
    private int _enemyDamage;
    private int _enemyHealth;
    private int _playerDamage;
    private int _hitPoints = 10;
    private float _coolDown = 2;
	// Use this for initialization
	void Start () {
        _enemyHealth = GetComponent<EnemyBehaviour>();
    }
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(_coolDown);

        if (Input.GetKeyDown("space") && _coolDown <= 0)
        {
            if (_enemyType == 1)
            {
                _hitPoints -= _enemyDamage;
                Debug.Log("attack 1");
            }
            else if (_enemyType == 2)
            {
                _enemyHealth -= _playerDamage;
                Debug.Log("attack 2");
            }
            _coolDown = 2;
        }

        else if (Input.GetKeyDown("enter") && _coolDown <=0)
        {
            if (_enemyType == 2)
            {
                _hitPoints -= _enemyDamage;
            }
            else if (_enemyType == 1)
            {
                _enemyHealth -= _playerDamage;
            }
            _coolDown = 2;
        }
        if (_coolDown > 0)
        {
            _coolDown -= 1 * Time.deltaTime;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        if (other.tag == Tags.ENEMY)
        {
            Debug.Log("take damage");
            Destroy(other.gameObject);
        }
    }
}
