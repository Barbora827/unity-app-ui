using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
public void GotoMainScene(int index)
{
SceneManager.LoadScene(index);
}

}