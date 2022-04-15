using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3;

    //用来控制坦克左右移动
    private SpriteRenderer sr;
    public Sprite[] tankSprite;
    // Start is called before the first frame update
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //水平方向 左右键
        float h = Input.GetAxisRaw("Horizontal");
        //水平方向移动
        transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);

        //left
        if(h < 0)
        {
            sr.sprite = tankSprite[3];
        }
        //right
        else if(h > 0)
        {
            sr.sprite = tankSprite[1];
        }

        //垂直方向 上下键
        float v = Input.GetAxisRaw("Vertical");
        //垂直方向移动
        transform.Translate(Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);

        //up
        if(v < 0)
        {
            sr.sprite = tankSprite[2];
        }
        //down
        else if(v > 0)
        {
            sr.sprite = tankSprite[0];
        }

    }
}
