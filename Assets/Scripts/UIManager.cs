using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // ENCAPSULATION
    public static UIManager Instance { get; private set; }
    [SerializeField] private InformationPanel InformationPanel;
    protected IUIInfoContent m_CurrentContent;

    public interface IUIInfoContent
    {
        string GetName();
        string GetDescription();
        int GetDamage();
        float GetWeight();
        int GetPrice();
    }

    private void Awake()
    {
        Instance = this;
        InformationPanel.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (m_CurrentContent == null)
            return;

        // ABSTRACTION
        UpdateInformation(m_CurrentContent);
    }

    public void SetNewInfoContent(IUIInfoContent content)
    {
        if (content == null)
        {
            InformationPanel.gameObject.SetActive(false);
        }
        else
        {
            InformationPanel.gameObject.SetActive(true);
            m_CurrentContent = content;

            // ABSTRACTION
            UpdateInformation(content);
        }
    }

    public void ClearInfoContent()
    {
        InformationPanel.gameObject.SetActive(false);
    }

    // ABSTRACTION
    private void UpdateInformation(IUIInfoContent content)
    {
        InformationPanel.Name.text = content.GetName();
        InformationPanel.Description.text = content.GetDescription();
        InformationPanel.Damage.text = "Damage: " + content.GetDamage().ToString() + " dph";
        InformationPanel.Weight.text = "Weight: " + content.GetWeight().ToString() + " kg";
        InformationPanel.Price.text = "Price: " + content.GetPrice().ToString() + " $";
    }
}
