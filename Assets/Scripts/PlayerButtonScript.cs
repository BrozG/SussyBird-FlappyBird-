using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerButtonScript : MonoBehaviour
{
    public void PlayBUtton()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
