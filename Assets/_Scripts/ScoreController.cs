using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {
    public GameController _gameController;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Paper"))
        {

            this._gameController.ScoreValue += 100;
            Destroy(other.gameObject);
        }
    }
}
