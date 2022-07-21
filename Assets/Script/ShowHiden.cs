using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiden : MonoBehaviour
{
    public GameObject objectShow, objectHide;
    public void Actived()
    {
        objectShow.SetActive(true);
        objectHide.SetActive(false);
    }
}
