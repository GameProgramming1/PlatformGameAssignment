using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    //public instance variable
    public Speed speed;
    public Drift drift;
    public Boundary boundary;

    //private instance variable
    private float _Currentspeed;
    private float _Currentdrift;

    private AudioSource _EndEnemy;
    // Use this for initialization
    void Start()
    {

        this._Reset();


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = new Vector2(0.0f, 0.0f);
        currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.y += this._Currentdrift;
        currentPosition.x -= this._Currentspeed;
        //movve the gameobject to th ecurrent position
        gameObject.GetComponent<Transform>().position = currentPosition;

        //bottom boundray check oceans meets camra view point
        if (currentPosition.x <= boundary.minX)
        {
            this._Reset();
        }

    }
    //resets our game object
    private void _Reset()
    {
        this._Currentdrift = Random.Range(drift.minDrift, drift.maxDrift);
        this._Currentspeed = Random.Range(speed.minSpeed, speed.maxSpeed);
        Vector2 resetPosition = new Vector2(boundary.maxX, Random.Range(boundary.minY, boundary.maxY));
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
