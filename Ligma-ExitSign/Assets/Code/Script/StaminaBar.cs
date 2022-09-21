using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StaminaBar : MonoBehaviour

{
    
    [SerializeField] private float stamina;
    [SerializeField] private int maxStamina = 100;
    [SerializeField] private Slider staminaBar;
    private int currentStamina;
    public static StaminaBar instance;
    
    
    
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 0;
        currentStamina = maxStamina;
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;
    }

    public void UseStamina(int amount)
    {
        if (currentStamina - amount >=0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;
        }
        else
        {
            Debug.Log("Not stamina");
        }
    }

    
}
