using UnityEngine;

public class scriptjogador : MonoBehaviour
{
    [SerializeField] float velocidade = 8;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(movimentoHorizontal, 0, 0);
        
    }
}
