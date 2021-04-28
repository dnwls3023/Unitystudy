using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
  // public 으로 변수를 초기화 하면 유니티 엔진 내에서 값 변경이 가능하기 때문에
  // 디버그할 때 용이함
  public float jumpPower;
  bool isJump;
  Rigidbody rigid;
  
  void Awake()
  {
    isJump = false;
    rigid = GetComponent<Rigidbody>();
  }
  
  void Update()
  {
    if(Input.GetButtonDown("Jump") && !isJump){
      isJump = true;
      rigid.AddForce(new Vector(0,jumpPower,0), ForceMode.Impulse);
    }
  }
  
  // 물리 기반으로 움직일 것이므로
  void FixedUpdate()
  {
    float h = Input.GetAxisRaw("Horizontal");
    float v = Input.GetAxisRaw("Vertical");
    
    rigid.AddForce(new Vector3(h,0,v), ForceMode.Impulse);
    
  }
  
  void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.name == "Floor")
      isJump = false;
  }
  
}
