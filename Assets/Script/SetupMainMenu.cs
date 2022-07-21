using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupMainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject materi;
    public GameObject quit;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        materi.SetActive(false);
        quit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
