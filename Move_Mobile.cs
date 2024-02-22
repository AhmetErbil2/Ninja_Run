using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

//public class Move_Mobile : MonoBehaviour
//{
//    public Transform Yol2;
//    public Transform Yol1;
//    public Rigidbody Rigidbody;
//    public FixedJoystick joystick;
//    private Animator animator;
//    public TMP_Text buttonText;
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    private void FixedUpdate()
//    {
//        animator = GetComponent<Animator>();

//        Rigidbody.velocity = new Vector3(joystick.Horizontal*10, 0, joystick.Vertical*10);
//        if(joystick.Horizontal !=0||joystick.Vertical !=0)
//        {
//            transform.rotation = Quaternion.LookRotation(Rigidbody.velocity);
//            animator.SetBool("ÝsRun", true);
            
//        }
//        else
//        {
//            animator.SetBool("ÝsRun", false);
//        }
        


//    }

//    public void buton(int deger)
//    {
//        if (deger == 1)
//        {
//            animator.SetBool("ÝsRunJum", true);
//            transform.Translate(new Vector3(0, 3f, 0) * Time.deltaTime);
//            Debug.Log("zýplýyor");
//        }
//        else
//        {
//            animator.SetBool("ÝsRunJum", false);
//            Debug.Log("zýplamýyor");
//        }
        
//    }


//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.name == "1_Son")
//        {
//            Yol2.position = new Vector3(Yol1.position.x, Yol1.position.y, Yol1.position.z + 50.0f);
//        }
//        if (other.gameObject.name == "2_Son")
//        {
//            Yol1.position = new Vector3(Yol2.position.x, Yol2.position.y, Yol2.position.z + 50.0f);
//        }
//    }
//}
