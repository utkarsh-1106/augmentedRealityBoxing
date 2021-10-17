using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtnScript : MonoBehaviour
{
    bool isBoxing = false;
    public GameObject player;
    public GameObject videoPlane;
    Animator anim;

    void Start()
    {
        anim = player.GetComponent<Animator>();
        videoPlane.SetActive(false);
    }

    public void PlayAnim()
    {
        Debug.Log("PLAY clicked");
        isBoxing = true;

        anim.SetBool("IsBoxing", isBoxing);

        //Play video
        videoPlane.SetActive(true);
    }

    public void PauseAnim()
    {
        Debug.Log("PAUSE clicked");
        isBoxing = false;

        anim.SetBool("IsBoxing", isBoxing);

        //Pause video
        videoPlane.SetActive(false);
    }
}
