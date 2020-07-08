using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU_MANAGER : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MAIN());        
    }
    IEnumerator MAIN()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main");
    }
    
}
