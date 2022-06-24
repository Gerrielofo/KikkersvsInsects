using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
	public GameObject setUI;
	public static GameObject ui;

	public Text upgradeCost;
	public Button upgradeButton;

	public Text sellAmount;

	private Nodes target;


    private void Start()
    {
		ui = setUI;
    }
    public void SetTarget(Nodes _target)
	{
		target = _target;

		transform.position = target.GetBuildPosition();

		if (!target.isUpgraded)
		{
			upgradeCost.text = "UPGRADE $" + target.turretBlueprint.upgradeCost;
			upgradeButton.interactable = true;
		}
		else
		{
			upgradeCost.text = "DONE";
			upgradeButton.interactable = false;
		}

		sellAmount.text = "SELL $" + target.turretBlueprint.GetSellAmount();

		ui.SetActive(true);
	}

	public static void Hide()
	{
		ui.SetActive(false);
	}

	public void Upgrade()
	{
		target.UpgradeTurret();
		BuildManager.instance.DeselectNode();
	}

	public void Sell()
	{
		target.SellTurret();
		BuildManager.instance.DeselectNode();
	}

}