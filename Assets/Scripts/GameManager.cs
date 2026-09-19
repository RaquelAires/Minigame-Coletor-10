using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int bolinhasColetadas = 0;
    public int totalBolinhas = 10;

    public void ColetarBolinhas()
    {
        bolinhasColetadas++;

        Debug.Log("Bolinhas coletadas: " + bolinhasColetadas + "/" + totalBolinhas);

        if (bolinhasColetadas >= totalBolinhas)
        {
            Debug.Log("Você venceu!");
        }
    }
}