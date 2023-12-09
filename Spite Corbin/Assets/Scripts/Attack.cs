using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator anim;
    private Rigidbody2D rb;


    private float timer = 0f;
    private double waitAttack = .5;
    private float lastAttack;
    public bool isAttacking = false;
    private GameObject attackArea = default;






    void Start()
    {
        anim = GetComponent<Animator>();
        attackArea = transform.GetChild(0).gameObject;
    }
    
   


    private void sideAttack()
    {
        if(Time.time - lastAttack < waitAttack)
        {
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            isAttacking = true;
            attackArea.SetActive(isAttacking);
            anim.SetTrigger("SideAttack");
            lastAttack = Time.time;
        }
        if (isAttacking)
        {
            timer += Time.deltaTime;

            if (timer > .5)
            {
                timer = 0;
                isAttacking = false;
                attackArea.SetActive(isAttacking);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        sideAttack();
    }
}
