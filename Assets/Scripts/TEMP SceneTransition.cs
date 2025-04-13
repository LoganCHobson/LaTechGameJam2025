using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEMPSceneTransition : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public GameObject player;
    public Vector3 teleportLocation = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextArea();
        }
    }

    public void LoadNextArea()
    {
        StartCoroutine(LoadArea(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadArea(int levelIndex)
    {
        transition.SetTrigger("ChangeScene");

        yield return new WaitForSeconds(transitionTime);
        player.transform.position = teleportLocation;
        yield return new WaitForSeconds(transitionTime);

        transition.SetTrigger("ExitChange");

    }
}
