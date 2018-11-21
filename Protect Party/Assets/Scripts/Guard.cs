using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {
    public int GuardType; // 1=perfect ,  2=normal
    public ShieldController shieldhp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "FireBall")
        {
            Debug.Log("qweqe");
            if (GuardType == 1)
            {
                shieldhp.shieldgauge -= 1;
                // GameObject.Find("Circle").SendMessage("ShieldController", 1);
               // shieldhp.gameObject.SendMessage("DefecneSucceed", 1);
                //Destroy(col);
                //col.gameObject.SendMessage("DestroyObject");
                Debug.Log("pgurard");
               // col.GetComponent<FireBall>().DestroyObject();
            }
            else if (GuardType == 2)
            {
                shieldhp.shieldgauge -= 5;
                //GameObject.Find("Circle").SendMessage("ShieldController", 10);
                //hieldhp.gameObject.SendMessage("DefecneSucceed", 5);
                Debug.Log("normalgurard");
                //Destroy(col);
               // col.gameObject.SendMessage("DestroyObject");
               // col.GetComponent<FireBall>().DestroyObject();
            }
            col.SendMessage("DestroyObject");
        }
    }
    private void OnCollisionEnter(Collision col)
    {
      
    }
}
