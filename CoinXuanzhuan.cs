using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinXuanzhuan : MonoBehaviour {

    public Vector3 Rot;
	// Update is called once per frame
	void Update () {
        transform.Rotate(Rot);
	}
}
