using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform Yol2;
    public Transform Yol1;
    private Animator animator;
    private int T_Altin;
    private int Puan;
    


    // Start is called before the first frame update




    void Start()
    {
        animator = GetComponent<Animator>();    
    }
    

    // Update is called once per frame
    private void FixedUpdate()
    {   //////////////////////////// Düz koþu kodu
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("ÝsRun", true);
            transform.Translate(new Vector3(0, 0, 3f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("ÝsRun", false);
        }

        ///////////// hýzlý kosu kodu
        if (Input.GetKey(KeyCode.LeftShift)&& (Input.GetKey(KeyCode.W)) )
        {
            animator.SetBool("ÝsFast", true);
            transform.Translate(new Vector3(0, 0, 3f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("ÝsFast", false);
        }
       

        ///////////////////////////koþarken sýçrama
        if (Input.GetKey(KeyCode.Space) && ((Input.GetKey(KeyCode.LeftShift)) || (Input.GetKey(KeyCode.W))))
        {
            animator.SetBool("ÝsRunJum", true);
            transform.Translate(new Vector3(0, 5f, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("ÝsRunJum", false);
        }
        //////////Saða sola dönüþ
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-4f, 0, 0) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(4f, 0, 0) * Time.deltaTime);
        }
        ///////////geri gelme
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -5f) * Time.deltaTime);
    
        }

        
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="1_Son")
        {
            Yol2.position = new Vector3(Yol1.position.x, Yol1.position.y, Yol1.position.z + 200.0f);
            Puan++;
        }
        if(other.gameObject.name == "2_Son")
        {
            Yol1.position = new Vector3(Yol2.position.x, Yol2.position.y, Yol2.position.z + 200.0f);
            Puan++;
        }

        if (other.gameObject.tag == "Altin")
        {
            T_Altin++;
            Debug.Log(T_Altin);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag=="Tas")
        {
            T_Altin--;
            Debug.Log(T_Altin);
            Destroy(other.gameObject, 2f);

        }
    }

    




}
