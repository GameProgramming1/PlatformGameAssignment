using UnityEngine;
using System.Collections;

public class CoinObjectScript : MonoBehaviour {
    //public instance variable
    public int coinCount;
    public GameObject coin;


	// Use this for initialization
	void Start () {
        this._GenerateCoins();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //generate cloud
    private void _GenerateCoins()
    {
        for (int count = 0; count < this.coinCount; count++)
        {
            Instantiate(coin);
        }
    }
}
