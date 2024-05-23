public class HookBehaviour : MonoBehaviour
{
    // Since HarmonyLib is having some compatiblity issues, thats the easiest way to "hook" something, i guess.
    public void Update()
    {
        if (PlayerControl.LocalPlayer != null)
        {
            PlayerControl.LocalPlayer.nameText.Text = "BOMBER COMING LATER DW";
        }
    }
}