using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChanger : MonoBehaviour
{
    //public SceneFader sf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToLevel(int lvl) {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level0" + lvl.ToString());
        //sf.FadeTo("Level0" + lvl.ToString());
    }
}
