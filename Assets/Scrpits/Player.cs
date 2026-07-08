using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//引用组件，UI。

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    // Start is called before the first frame update

    public int score = 0;//分数

    public TextMeshProUGUI textComponent;//这就是Text组件，用于记录分数。

    public GameObject winTextGo;//创建一个新物体，绑定游戏胜利的文本。

    void Start()
    {
        Debug.Log("2333333");
    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce(Vector3.right);//施加一个方向向右的力。x y z   1，0，0
        float h = Input.GetAxisRaw("Horizontal");//按ad可以获取一个1或者-1的值。
        float v = Input.GetAxisRaw("Vertical");//按ws可以获取一个1或者-1的值。

        Vector3 dir = new Vector3(h,0,v);
        rd.AddForce(dir*3);//给rd给予一个力。
    }

    private void OnCollisionEnter(Collision collision)//每次发生碰撞的时候，会触发这个函数
    {
        Debug.Log("Enter" + collision.gameObject.name);//每次碰撞的时候，还要输出碰撞的物体的名字。

        if (collision.gameObject.tag == "Food")//如果碰撞的物体的标签是Food，则销毁这个食物。 分数加一。
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision) 
    { 
        Debug.Log("Stay" + collision.gameObject.name);

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit" + collision.gameObject.name);

    }

    //触发检测
    private void OnTriggerEnter(Collider other)//boxcollider、meshcollider，这里传的是碰撞的组件。
    {
        //Debug.Log("OnTriggerEnter" + other.gameObject.name);
        Debug.Log("OnTriggerEnter" + other.name);//每次碰撞的时候，还要输出碰撞的物体的名字。

        if (other.tag == "Food")//如果碰撞的物体的标签是Food，则销毁这个食物。 
        {
            score++;//分数+1。
            textComponent.text = score.ToString();//把int类型的分数，转换为字符串赋值给text。

            Destroy(other.gameObject);

            if (score == 10)//食物吃完了，显示胜利的文本。
            {
                winTextGo.SetActive(true);
            }
        }

    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay" + other.name);

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit" + other.name);

    }
}




