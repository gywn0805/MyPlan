using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    //mouse 클릭시 캐릭터 카메라 앞으로 이동 및 알파값 감소
    public Transform target;
    public Transform rightarm;
    public float speed;
    public float shieldgauge;

    //  public MeshRenderer rnd;
    public Material publmat;
    public Material publmat2;
    //   public MeshRenderer rnd1;
    // public MeshRenderer rnd2;
    //  public MeshRenderer rnd3;
    public GameObject normalguard;
    public GameObject perfectguard;
    private float ptimer;


    void DefenceSucceed(float damage)
    {
        shieldgauge -= damage;
    }
    // Use this for initialization
    void Start()
    {
        shieldgauge = 100;
        ptimer = 3f;
        publmat.color = new Vector4(publmat.color.r, publmat.color.b, publmat.color.g, 1f);
        publmat2.color = new Vector4(publmat2.color.r, publmat2.color.b, publmat2.color.g, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(shieldgauge);
        if (Input.GetMouseButton(1))
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            if (transform.position == target.position)
            {
                publmat.color = new Vector4(publmat.color.r, publmat.color.b, publmat.color.g, 0.7f);
                publmat2.color = new Vector4(publmat2.color.r, publmat2.color.b, publmat2.color.g, 0.6f);
                perfectguard.SetActive(true);
                if(ptimer>0)
                {
                    ptimer -= Time.deltaTime;
                }
                else
                {
                    perfectguard.SetActive(false);
                    normalguard.SetActive(true);
                }

            }
        }
        else
        {
            normalguard.SetActive(false);
            perfectguard.SetActive(false);
            if(ptimer<3)
            {
                ptimer = 3f;
            }
            publmat.color = new Vector4(publmat.color.r, publmat.color.b, publmat.color.g, 1f);
            publmat2.color = new Vector4(publmat2.color.r, publmat2.color.b, publmat2.color.g, 1f);
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, rightarm.position, step);
        }
    }
}
