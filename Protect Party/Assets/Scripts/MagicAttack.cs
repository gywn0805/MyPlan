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
        magicPosition1.LookAt(partypos);
        magicPosition2.LookAt(partypos);
        magicPosition3.LookAt(partypos);
    }
    IEnumerator Wave1()
    {
        remain = 50;
        while (remain > 0) 
        {
            spawnPointSelect = Random.Range(1, 4);
            if (spawnPointSelect == 1)
            {
                Instantiate(fireball,new Vector3( magicPosition1.transform.position.x, magicPosition1.transform.position.y-0.9f, magicPosition1.transform.position.z), transform.rotation);
            }
            if (spawnPointSelect == 2)
            {
                Instantiate(fireball, new Vector3(magicPosition2.transform.position.x, magicPosition2.transform.position.y - 0.9f, magicPosition2.transform.position.z), transform.rotation);
            }
            if (spawnPointSelect == 3)
            {
                Instantiate(fireball, new Vector3(magicPosition3.transform.position.x, magicPosition3.transform.position.y - 0.9f, magicPosition3.transform.position.z), transform.rotation);
            }
            remain--;
            yield return new WaitForSeconds(3.0f);
        }
       
    }
}
