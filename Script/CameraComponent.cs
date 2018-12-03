using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponent : MonoBehaviour {
    public GameObject Sphere;
    private Vector3 offset;
	// Use this for initialization
	void Start () {//初始化摄像头位置
        offset = transform.position - Sphere.transform.position;//现在摄像机与球的位置差
	}
	
	// Update is called once per frame
	void LateUpdate () {//处理镜头在lateupdate里写
        transform.position = Sphere.transform.position + offset;//保证摄像机和球同步运动
	}
}
