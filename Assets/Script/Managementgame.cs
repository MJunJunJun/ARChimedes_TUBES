using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managementgame : MonoBehaviour
{
    public int garam;
    public Animator animator;
    public GameObject garamBtn;
    public GameObject txtAtas,txtTengah, txtBawah;
    // Start is called before the first frame update
    void Start()
    {
        garam = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TambahGaram()
    {
        garam++;
        animator.Play("Garam");
    }
    public void Telur()
    {
        if (garam == 0)
        {
            animator.Play("Tenggelam");
            txtBawah.SetActive(true);
        }
        else if (garam == 1)
        {
            animator.Play("Ditengah");
            txtTengah.SetActive(true);
        }
        else if (garam >= 2)
        {
            animator.Play("diatas");
            txtAtas.SetActive(true);
        }
        garamBtn.SetActive(false);
    }
}
