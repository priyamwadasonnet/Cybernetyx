using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D Rb;
    public float speed = 2.5f;
    private void Start()
    {
        anim.SetBool("destroy", false);
    }
    private void Update()
    {
        Rb.velocity = new Vector2(0, speed);
    }

    private void OnMouseDown()
    {
        RaycastHit2D ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (ray.collider != null)
        {
            Debug.Log(ray.collider.gameObject.name);
            anim.SetBool("destroy", true);
            Destroy(this.gameObject, 0.7f);
        }
    }
}