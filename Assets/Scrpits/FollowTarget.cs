using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{

    public Transform trans;//获取Transform组件的信息，其实不用这一句也可以获取，因为这个脚本已经绑定了相机了。
    public GameObject player;//获取一个游戏物体，需要在Unity里面绑定。   
    // Start is called before the first frame update

    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;//计算偏移量。小球和相机的。
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
 