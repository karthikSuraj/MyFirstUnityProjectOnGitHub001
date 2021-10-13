using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceanChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadScenOne()
    {
        SceneManager.LoadScene(1);
    }
    public void loadScenTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void loadScenThree()
    {
        SceneManager.LoadScene(3);
    }
    public void loadScenMain()
    {
        SceneManager.LoadScene(0);
        //assasa
    }
}
