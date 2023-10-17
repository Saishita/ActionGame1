using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 5;
    
    private Rigidbody2D rb2d;

    private Animator anim;

    private SpriteRenderer spRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        this.spRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");//左に－1・何もしない０・右に１
        
                anim.SetFloat("Speed",Mathf.Abs(x * speed));
        
                // スプライトの向きを変える
                if (x < 0)
                {
                    spRenderer.flipX = true;
                }else if(x > 0)
                {
                    spRenderer.flipX = false;
                }
        
        Debug.Log(x);
        rb2d.AddForce(Vector2.right * x * speed);

        transform.DOLocalMove(new Vector3(10f, 0, 0), 1f);
    }
}
