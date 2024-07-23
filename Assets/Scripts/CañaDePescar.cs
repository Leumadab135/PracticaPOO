
using UnityEngine;

public class CañaDePescar : MonoBehaviour
{
    //Public Attributes
    public int _durability;

    //Public Methods
    public void Usar()
    {
        if (_durability > 0)
        {
            _durability -= 1;
            print("La caña ha sido usada, la durabilidadad restante es de " + _durability + " usos.");
            
        }
        else
        {
            if (_durability <= 0) 
            {
            print("Noo NOOO NOOOOOOOOOO MI CAÑA TIOOOOOOOOOO ZEMAROTOOOO ZURMANO!");
            }
        }
    }
}
