using UnityEngine;

public class DontDestroyMe : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
