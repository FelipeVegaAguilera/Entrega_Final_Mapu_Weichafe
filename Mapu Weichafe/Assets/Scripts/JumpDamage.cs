using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDamage : MonoBehaviour
{
    public Collider2D collider2d;
    public Animator anim;
    public SpriteRenderer sprtR;

    public GameObject destroyParticle;

    public float jumpForce = 3f;
    public int lifes = 2;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * jumpForce);
            LosseLifeAndHit();
            CheckLife();
        }
    }

    public void LosseLifeAndHit()
    {
        lifes--;
        anim.Play("Hit_Bat");
    }
    
    public void CheckLife()
    {
        if (lifes == 0)
        {
            destroyParticle.SetActive(true);
            sprtR.enabled = false;
            Invoke("EnemyDie", 0.2f);
        }
    }

    public void EnemyDie()
    {
        Destroy(gameObject);
    }

}
