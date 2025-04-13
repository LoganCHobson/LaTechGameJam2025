using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string scene = "GamePlay";
    public Vector3 teleportLocation = new Vector3(0, 0, 0);
    // Start is called before the first frame update


    public void LoadNextArea()
    {
        StartCoroutine(LoadArea(scene));
    }

    IEnumerator LoadArea(string scene)
    {
        transition.SetTrigger("ChangeScene");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }
}
