using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterBehaviour : MonoBehaviour
{   
    //전역 변수들 중 선언만 한 변수들은 Inspector창에서 조정합니다. 기획자와 QA를 배려하는 코딩...?
     
   //제어할 컴포넌트들을 선언
    private Rigidbody rb;
    private Animator animator;
     private Transform Monster;
    [SerializeField] int hp; //hp 계산
  //애니메이터
   [SerializeField] Transform player; 
 
   NavMeshAgent nvAgent;
  
    void Start()
    {  //제어할 컴포넌트들을 가져옴.
         Monster = GetComponentInChildren<Transform> (); 
        Animator animator = GetComponentInChildren<Animator>();
        nvAgent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
        rb = GetComponentInChildren<Rigidbody> ();
       
    }

    void Update()
    {
      
        if(Vector3.Distance(player.position, Monster.transform.position) < 3.5f)
        {
            findPlayer();
        }
    }
   

 
    void findPlayer()
    {
        animator.SetTrigger("Walk") ;
        nvAgent.destination = player.position;
    }

}
