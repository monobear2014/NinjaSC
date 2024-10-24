using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatText : MonoBehaviour
{
    [SerializeField] Text hpText;

    public void OnInit(float damage)
    {
        hpText.text = damage.ToString();
        Invoke(nameof(onDespawn), 1f);
    }

    public void onDespawn()
    {
        Destroy(gameObject);
    }
}
