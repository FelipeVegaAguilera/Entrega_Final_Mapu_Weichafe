using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    
    public GameObject[] hearts;

    private int life;

    private float checkPointPositionX;
    private float checkPointPositionY;

    public Animator anim;

    void Start()
    {
        life = 3;

        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }
  

    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX",x);
        PlayerPrefs.SetFloat("checkPointPositionY",y);
    }

    public void PlayerDamaged()
    {
        life--;

        if (life < 1)
        {
            
            anim.Play("Player_Death");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            GetComponent<Heart_Destroy>().Destroyed();
            
        }
        else if(life < 2)
        {
            
            anim.Play("Player_Death");

        }
        else if(life < 3)
        {
            
            anim.Play("Player_Death");
            GetComponent<Heart_Destroy>().Destroyed();
        }

    }

    public void PlayerDamaged2()
    {
        anim.Play("Player_Death");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }


}
