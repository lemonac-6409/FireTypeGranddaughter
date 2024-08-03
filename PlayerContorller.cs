using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//이하 임채은 초기코드 작성 및 송종익 등 수정
public class PlayerContorller : MonoBehaviour
{   
    int hp;
    Transform Player;
    private Animator animator;
    public float moveSpeed = 5f;
    public float turnSpeed = 200f;
    private GameObject rb; 
    //작업 시작합니다. (이채은)
    float time;
    public float speed;
    public GameObject magic1;   //마법1(물)
    public GameObject magic2;   //마법2(불)
    public GameObject magic3;   //마법3(흙)
    public GameObject magic4;   //마법4(바람)
    public GameObject magic5;   //마법5(빛)
	public Transform firePos;   //발사구(마법봉)
    public class Shooter : MonoBehaviour

 public class BulletController : MonoBehaviour
 {
    public float speed;
    float time;

    void start()
    {
        speed = 30.0f;
        time = 0;
    }

    void update()
    {
        FireBullet();
        DestroyBullet();
    }

    void FireBullet()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {
         time += Time.deltaTime;
         if (time > 0.5f)
         {
             Destoy(GameObject);
         }
    }
 }

private void start()
{
    time = 0;
    speed = 10.0;
}

private void update()
{
   Move();
   FireBullet
}

public void Move()
{
   float x = Input.GetAxis("Horizontal") * speed * Time.delteTime;
   float y = Input.GetAxis("Vertical") * speed * Time.delteTime;

   transform.Translate(new Vector3(x, y, 0));

   if (transform.position.x > limitMax.x)...
   if (transform.position.y > limitMax.y)...
   if (transform.position.x > limitMax.x)...
   if (transform.position.y > limitMax.y)...
}

public void FireBullet()
{
    time += Time.deltatime;
    Debug.Log("Fire" + time);
    if (time > 0.03f)
    {
        Instantiate(prefabBullet, transform.position, Quaternion.identity);
        time -+ 0.3f;
    }
}


    //Inspertor 창과 Scene창에서 조정을 편리하게 하기 위해서 Strartingpoin를 만들어줍니다.
    [SerializeField] GameObject Startingpoint;

    


    void Start ()
    {
        hp = 1;
        Player = GetComponent<Transform>();
         //부모 오브젝트가 아닌, Player의 자식 오브젝트를 컨트롤할 것이므로 GetComponentInChildren을 사용합니다.
        animator = GetComponentInChildren<Animator>();
        //기획자가 원하는 Startingpoint 
        Player.position = Startingpoint.transform.position;
      
    }
     void Update()
    {
        
        Die();
        Move();
        Turn();
         //마법 발사 Animation을 찾는다면 넣읍시다.shot();
	}
}
        
    }
    void OnCollisionEnter(Collision other)
    {
        animator.SetTrigger("hited");
        hp -=1;
    }

    void Die()
    {
        if(hp==0)
        {
            animator.SetBool("Die", true);
        }
    }

    void Move()
    {   //위치이동

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);

        //걷는 애니메이션 넣기
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("walk");
        }
        else
        {
            animator.ResetTrigger("walk");
        }
        //공격 애니메이션을 찾지 못해서 아래는 주석처리
      /*  if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            
        }
        else
        {
            animator.ResetTrigger("attack");
        }
        */

      
        
    }
    void Turn()
    {
        //회전값 변화
    float turnHorizontal = Input.GetAxis("Mouse X");
    float turnVertical = Input.GetAxis("Mouse Y");

    Vector3 rotation = new Vector3(0, turnHorizontal, 0);

    transform.Rotate(rotation * turnSpeed * Time.deltaTime);

    }
   /* void shot()
    {
        
    }
    */
    
    
   
}
