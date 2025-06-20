using UnityEngine;
using UnityEngine.UI;

public class hpButtonCaller : MonoBehaviour
{
    public void OnClickAddHp()
    {
        if (HP.Instance != null)
            HP.Instance.ControlHp();
    }
}
