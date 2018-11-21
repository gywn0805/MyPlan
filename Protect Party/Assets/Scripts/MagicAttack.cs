using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack : MonoBehaviour {

    public int spawnPointSelect;
    public Transform partypos;
    public GameObject fireball;
    public Transform magicPosition1;
    public Transform magicPosition2;
    public Transform magicPosition3;
    public float remain;

	// Use this for initialization
	void Start () {
        StartCoroutine(Wave1());
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    IEnumerator Wave1()
    {
        remain = 50;
        while (remain > 0) 
        {
            spawnPointSelect = Random.Range(1, 4);
            if (spawnPointSelect == 1)
            {
                Instantiate(fireball, magicPosition1.transform.position, transform.rotation);
            }
            if (spawnPointSelect == 2)
            {
                Instantiate(fireball, magicPosition2.transform.position, transform.rotation);
            }
            if (spawnPointSelect == 3)
            {
                Instantiate(fireball, magicPosition3.transform.position, transform.rotation);
            }
            remain--;
            yield return new WaitForSeconds(3.0f);
        }
       
    }
}
