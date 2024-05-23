public class HookBehaviour : MonoBehaviour
{
    // Since HarmonyLib is having some compatiblity issues, thats the easiest way to "hook" something, i guess.
    public void Update()
    {
        /* This is used for beta testing, and i dont want this shit appearing anymore lol.
        if (PlayerControl.LocalPlayer != null)
        {
            PlayerControl.LocalPlayer.nameText.Text = "BOMBER COMING LATER DW";
        }
        */
    }
}