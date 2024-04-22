
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBAr : MonoBehaviour
{
    public TextMeshProUGUI HpText;
    public Slider hpslider;
    public Health CharacterHealth;

    private void Start()
    {
        hpslider.maxValue = CharacterHealth.maxHealth;
    }
    void Update()
    {

        HpText.text = CharacterHealth.current_health+"/"+CharacterHealth.maxHealth;
        hpslider.value = CharacterHealth.current_health;
    }
}
