using UnityEngine;
using System.Collections;

public class Touch : Sense
{
    void OnTriggerEnter(Collider other)
    {
        Aspect aspect = other.GetComponent<Aspect>();
        if (aspect != null)
        {
            //Check the aspect
            if (aspect.aspectName == aspectName)
            {
                print("Enemy Touch Detected");
                System.Console.WriteLine("Enemy  Touch Detected");
                //if (other.gameObject.tag == "Player")
                //{
                //    //DestroyObject(other.gameObject);
                //}
            }
        }
        }
    }

