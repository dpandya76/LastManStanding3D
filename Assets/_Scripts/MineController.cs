using UnityEngine;
using System.Collections;

public class MineController : MonoBehaviour {

    public Transform spawnPoint;
    public GameController gamecontroller;
    public GameObject explosion;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Transform playerTransform = other.gameObject.GetComponent<Transform>();
            playerTransform.position = this.spawnPoint.position;
            gamecontroller.LivesValue -= 1;
            Instantiate(this.explosion);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
