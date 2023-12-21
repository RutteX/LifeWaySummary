using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        TriggerDialog();
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        FindObjectOfType<DialogManager>().EndDialog();
    }
}
