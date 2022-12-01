using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modified : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] int height;

    float widthMul = 0.0005f;
    float heightMul = 0.01f;

    [SerializeField] Renderer renderer;

    [SerializeField] Transform topSpine;
    [SerializeField] Transform bottomSpine;
    [SerializeField] Transform Collider;
        
    void Update()
    {
        
        if (Input.GetKeyDown("q"))
        {
            Addwidth(20);
        }if (Input.GetKeyDown("e"))
        {
            Addheight(20);
        }
    }

    public void Addwidth(int value)
    {
        width += value;
        renderer.material.SetFloat("_PushValue", width*widthMul);
    }
    public void Addheight(int value)
    {
        height += value;
        topSpine.position = bottomSpine.position + new Vector3(0, height * heightMul + 0.17f, 0);
        Collider.localScale= new Vector3(1, 1.84f + height*heightMul, 1);
    }
}
