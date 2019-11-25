using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public Animation gunani;
    public Animator ani;
    public GameObject player;
    public GameObject Cam;
    public Transform bullets;
    public Transform projectile;
    public float fireforce;
    public GameObject Gun;
    public Rigidbody prigd;
    public GameObject enm;
    // public LineRenderer laserLineRenderer;
    //public float laserWidth = 0.1f;
    // public float laserMaxLength = 5f;
    


    public Text texty;
    public int scorecount = 0;


    private void Awake()
    {
        enm = GameObject.FindWithTag("enm");
    }


    public void Update()
    {

      
  

        shoooting();

       
       
    }

    public void shoooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Ray shoot;
            //  ani.SetBool("newBool", false);
            //this ray is shooting out from the main cameras screen point center of screen
            shoot = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            RaycastHit hitInfo;


            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(shoot, out hitInfo, 100000))

                if (hitInfo.collider.CompareTag("enm"))
                {

                    scorecount += 1;
                    Debug.Log("enm");
                    //Destroy(GameObject.FindWithTag("enm"));
                    Destroy(hitInfo.collider.gameObject);
                    texty.text = "Score:  " + scorecount;

                    //  ani.SetTrigger("firetgr");
                    //ani.SetBool("newBool", true);
                }
        }
    }

    public void enmisdead()

    {

        //
        if (enm == null)
        {
            Debug.Log("enm_dead");
            // Assert.IsTrue(enmdead = null);
        }
    }


    public void AddScore(int scoreToAdd)
    {
        
    }
}









