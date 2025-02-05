using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    private FallTrigger[] pins;
    

    void Start()
    {
       pins = Object.FindObjectsByType<FallTrigger>(FindObjectsSortMode.None);

        foreach(FallTrigger pin in pins){
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }
    
    public void IncrementScore(){
        score++;
        scoreText.text = $"Score: {score}";
    }

   
    void Update()
    {
        
    }
}
