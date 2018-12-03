using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //从键盘上输入运动方向
        float HoriInput=Input.GetAxis("Horizontal");
        float VertiInput=Input.GetAxis("Vertical");
        //设置一个力让球运动，x,y,z，y轴不让它动，所以设置为0
        Vector3 Movement = new Vector3(HoriInput,0,VertiInput);

        rb.AddForce(Movement*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Coin")
            other.gameObject.SetActive(false);//当碰撞时隐藏other object
    } 
}
