using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetailsManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _title;

    [SerializeField]
    private TextMeshProUGUI _city;

    [SerializeField]
    private TextMeshProUGUI _details;

    [SerializeField]
    private GameObject _BoxDetails;

    private Details _actualDetails;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void inicializa(Details details)
    {
        _actualDetails = details;
        _title.text = _actualDetails.GetMissionTitle();
        _city.text = _actualDetails.GetMissionCity();
        _details.text = _actualDetails.GeMissionContent();
        _BoxDetails.SetActive(true);
    }

    public void abortar()
    {
        _BoxDetails.SetActive(false);
    }

    public void irParaMissao()
    {
        SceneManager.LoadScene(_actualDetails.GetMissionId());
    }
}
