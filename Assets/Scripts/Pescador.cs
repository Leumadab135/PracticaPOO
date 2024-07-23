
using UnityEngine;

public class Pescador : MonoBehaviour
{
    //Attributes
    public string playerName;
    public Pez pezCapturado;
    public Ca�aDePescar ca�a;
    public bool pescar = false;

    //Methods

    private void Update()
    {
        if (pescar)
        {
            UsarCa�a(ca�a);
            pescar = false;
        }
    }
    public void Pescar (Pez pez)
    {
        pez = pezCapturado;

        if (pezCapturado != null)
        {
            print("OMG " + playerName.ToUpper() + " HA CAPTURADO UN/A " + pezCapturado.specie.ToUpper() + " DE " + pezCapturado.weight + " KG!!!");
            if (pez.isRare == true )
            {
                print("Y ADEM�S UN PEZ RARO!!!");
            }
        }
        else
        {
            print("No pican, nada a�n...");
        }
    }

    public void UsarCa�a (Ca�aDePescar ca�a)
    {
        if (ca�a != null && ca�a._durability > 0)
        {
            ca�a.Usar();
            Pescar(pezCapturado);
        }
        else 
        {
            if (ca�a == null)
            {
            print("Tengo que comprarme una ca�a");
            }

            else
            {
                if (ca�a._durability <= 0)
                {
                    print("NOOO mi ca�a se ha roto");
                }
            }

        }
    }


    //Private Attributes

    private void Start()
    {
        print("Qu� bonito d�a para pescar!!! Vamos a ello :D");
    }

}
