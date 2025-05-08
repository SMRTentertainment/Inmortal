using System;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private float jumpForce = 8f;
 private void OnCollisionEnter2D(Collision2D collision)
 {
  if (collision.transform.CompareTag("Player"))
  {
      collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = (Vector2.up * jumpForce);
  }
 }
}
