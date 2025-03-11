using UnityEngine;
using UnityEngine.UI;

public class pindahScene : MonoBehaviour
{
    public void scene(string scene)
    {
        Application.LoadLevel(scene);
    }
}
