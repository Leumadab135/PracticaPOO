
using UnityEngine;

public class Pescador : MonoBehaviour
{
    //Attributes
    public string playerName;
    public Pez pezCapturado;
    public CañaDePescar caña;
    public bool pescar = false;

    //Methods

    private void Update()
    {
        if (pescar)
        {
            UsarCaña(caña);
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
                print("Y ADEMÁS UN PEZ RARO!!!");
            }
        }
        else
        {
            print("No pican, nada aún...");
        }
    }

    public void UsarCaña (CañaDePescar caña)
    {
        if (caña != null && caña._durability > 0)
        {
            caña.Usar();
            Pescar(pezCapturado);
        }
        else 
        {
            if (caña == null)
            {
            print("Tengo que comprarme una caña");
            }

            else
            {
                if (caña._durability <= 0)
                {
                    print("NOOO mi caña se ha roto");
                }
            }

        }
    }


    //Private Attributes

    private void Start()
    {
        print("Qué bonito día para pescar!!! Vamos a ello :D");
    }

}
