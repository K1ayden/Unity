using UnityEngine;

public class DestroyOnStart : MonoBehaviour
{
    // ћетод вызываетс€ один раз при старте игры
    void Start()
    {
        // ”ничтожаем текущий игровой объект
        Destroy(gameObject);
    }
}
