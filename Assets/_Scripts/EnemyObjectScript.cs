using UnityEngine;
using System.Collections;

public class EnemyObjectScript : MonoBehaviour {

    //public instance variable
    public int EnemyCount;
    public GameObject Enemy;

    // Use this for initialization
    void Start()
    {
        this._GenerateEnemy();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //generate cloud
    private void _GenerateEnemy()
    {
        for (int count = 0; count < this.EnemyCount; count++)
        {
            Instantiate(Enemy);
        }
    }
}
