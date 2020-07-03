using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;
    public GameObject portal;
    SceneChange sceneChange;

    int sceneLoad;

    // Start is called before the first frame update
    void Start()
    {
        sceneChange = portal.GetComponent<SceneChange>();
        sceneLoad = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneChange.getPortalEntered())
        {
            fadeTransition();
        }
    }

    public void fadeComplete()
    {

        if (sceneLoad == 0)
        {
            SceneManager.LoadScene(sceneLoad + 1);
        }
        else if (sceneLoad == 1)
        {
            SceneManager.LoadScene(sceneLoad - 1);
        }
    }

    public void fadeTransition()
    {
        animator.SetTrigger("sceneTransition");
    }
}
