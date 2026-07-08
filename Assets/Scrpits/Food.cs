using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up);//围绕自身的y轴进行旋转。速度很快，和帧率有关。
        transform.Rotate(Vector3.up,Space.World);//围绕世界的y轴进行旋转。速度很快，和帧率有关。
    }
}
