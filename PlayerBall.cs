using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
  Rigidbody rigid;
  void Awake()
  {
    rigid = GetComponent<Rigidbody>();
  }
  // 물리 기반으로 움직일 것이므로
  void FixedUpdate()
  {
    float h = Input.GetAxisRaw("Horizontal");
    float v = Input.GetAxisRaw("Vertical");
    
    rigid.AddForce(new Vector3(h,0,v), ForceMode.Impulse);
    
  }
}
