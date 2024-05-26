public class BlackmailerRole : RoleBehaviour
{
    public enum RpcCalls
    {
        Blackmail = 0,
        Unblackmail = 1,
    }


    public override string roleDisplayName
    {
        get
        {
            string lang = TranslationController.Instance.CurrentLanguage.langName;
            if (lang == "Portugu�s") return "Chantageador";
            return "Blackmailer";
        }
    }

    public override string roleDescription
    {
        get
        {
            string lang = TranslationController.Instance.CurrentLanguage.langName;
            if (lang == "Portugu�s") return "Chantageie os outros e obtenha vantagens.";
            return "Blackmail others to gain advantages.";
        }
    }

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
        }
    }

    public override void ConfigureRole()
    {
        RoleTeamType = RoleTeamTypes.Impostor;
        enemyTeams = new RoleTeamTypes[] { RoleTeamTypes.Crewmate, RoleTeamTypes.Neutral };
        CanUseKillButton = true;
        CanVent = true;
        CanSabotage = true;
    }

    public override void OnAssign(PlayerControl player)
    {
        base.OnAssign(player);
        HudManager.Instance.KillButton.ButtonText.fontMaterial = CachedMaterials.Instance.BrookMaterials[1];
    }
}
