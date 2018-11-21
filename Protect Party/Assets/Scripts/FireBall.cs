using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {

    private GameObject targetposition;
    private float speed;

	// Use this for initialization
	void Start () {
        targetposition = GameObject.FindGameObjectWithTag("Playercoll");
        speed = Random.Range(2,5);
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetposition.transform.position, step);
	}
   
    public void DestroyObject()
    {
        Debug.Log("why not destroy now?");
        Destroy(gameObject);
    }
}
