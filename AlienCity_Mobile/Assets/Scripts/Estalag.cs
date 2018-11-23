using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Estalag : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Trig1.range == true)
        {
            anim.Play("estalag1");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Trap1.lives -= 1;
        Destroy(col.gameObject);
        SceneManager.LoadScene("Jogo");
    }
}