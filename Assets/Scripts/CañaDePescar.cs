
using UnityEngine;

public class Ca�aDePescar : MonoBehaviour
{
    //Public Attributes
    public int _durability;

    //Public Methods
    public void Usar()
    {
        if (_durability > 0)
        {
            _durability -= 1;
            print("La ca�a ha sido usada, la durabilidadad restante es de " + _durability + " usos.");
            
        }
        else
        {
            if (_durability <= 0) 
            {
            print("Noo NOOO NOOOOOOOOOO MI CA�A TIOOOOOOOOOO ZEMAROTOOOO ZURMANO!");
            }
        }
    }
}
