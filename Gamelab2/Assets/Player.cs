using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private int _playerDamage = 10;
    private int _enemyHealth;
    private int _enemyType;
    private int _enemyDamage;
    private int _hitPoints = 100;
    private float _coolDown = 2;
    private float _distends;
    private GameObject enemy;
    private Animator animator;
    private EnemyBehaviour[] _enemyBehaviour;

	void Start () {
        animator = GetComponent<Animator>();
      
        
    }

    void Update()
    {
        enemy = GameObject.FindGameObjectWithTag(Tags.ENEMY);
        _distends = enemy.transform.position.x - this.transform.position.x;
        _enemyType = enemy.GetComponent<EnemyBehaviour>().enemyType;
       
        Debug.Log(_enemyType);
        if (Input.GetKeyDown("space") && _distends < 5f)
        {
            if (_enemyType == 1)
            {
                animator.SetTrigger("Attack1");
                Destroy(enemy);
                Debug.Log("attack 2");
            }
        }

        if (Input.GetKeyDown("a") && _distends < 5f)
        {
            
            if (_enemyType == 2)
            {
                animator.SetTrigger("Attack2");
                Destroy(enemy);
                Debug.Log("attack 1");
            }
        }

        if (_hitPoints <= 0)
        {
            Destroy(this.gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == Tags.ENEMY)
        {
           _hitPoints -= _enemyDamage;
            Destroy(other.gameObject);    
        }

    }
}
